﻿using Autodesk.Authentication;
using Autodesk.Authentication.Helpers.Models;
using Autodesk.DataManagement;
using Sdk_Tests;
using WireMock.Server;

namespace Tests.DataManagement;

[TestClass]
public class DataManagementClientHelperTests
{
    private static WireMockServer? _server;
    private static readonly string PROXY_URL = "http://localhost:4200";
    private static readonly Settings config = Settings.Load();

    [ClassInitialize]
    public static void StartMockServer(TestContext context)
    {
        _server = APSmockServer.StartMockServer(PROXY_URL);
    }

    [ClassCleanup]
    public static void StopMockServer()
    {

        _server?.Stop();
        _server?.Dispose();
    }
    [TestMethod]
    public async Task ShouldReturnHubs()
    {

        var DMclient = InitializeDMclient();

        var hubs = await DMclient.DataMgtApi.Project.V1.Hubs.GetAsync();

        Assert.IsNotNull(hubs);
    }

    [TestMethod]
    public async Task ShouldReturnHubIdGivingItsName()
    {

        var DMclient = InitializeDMclient();

        var hubs = await DMclient.Helper.GetHubIdByNameAsync(config.HUB_NAME);

        Assert.IsNotNull(hubs);
    }

    [TestMethod]
    public async Task ShouldReturnProjectsGivingHubName()
    {

        var DMclient = InitializeDMclient();

        var projects = await DMclient.Helper.GetAllProjectsByHubNameAsync(config.HUB_NAME);

        Assert.IsNotNull(projects);
    }


    [TestMethod]
    public async Task ShouldReturnFileListWithinFolder()
    {

        var DMclient = InitializeDMclient();

        var files = await DMclient.Helper.GetLatestFilesVersionAsync(config.PROJECT_ID, config.FOLDER_ID);

        Assert.IsNotNull(files);
    }
    [TestMethod]
    public async Task ShouldReturnRevitFileListWithinFolder()
    {
        var DMclient = InitializeDMclient();


        var files = await DMclient.Helper.GetLatestFileVersionAsync(config.PROJECT_ID, config.FOLDER_ID, ["rvt"]);

        Assert.IsNotNull(files);
    }

    [TestMethod]
    public async Task ShouldFindFileByPath()
    {
        var DMclient = InitializeDMclient();

        var file = await DMclient.Helper.GetFileItemByPathAsync(config.SAMPLE_FILE_PATH);

        Assert.IsNotNull(file);
    }
    [TestMethod]
    public async Task ShouldReturnFolderGivingItsPath()
    {
        var DMclient = InitializeDMclient();

        var folderPath = Path.GetDirectoryName(config.SAMPLE_FILE_PATH) ?? throw new ArgumentException($"'{nameof(config.SAMPLE_FILE_PATH)}' is invalid");
        var folder = await DMclient.Helper.GetFolderByPathAsync(folderPath);

        //Minus 2 because the first element in the path is the hub name and the next one is the project name
        var subFoldersCount = folderPath.Split(['\\', '/']).Length - 2;

        Assert.IsTrue(folder.Folders.Count == subFoldersCount);
    }

    [TestMethod]
    public async Task ShouldReturnFoldersWithinFolder()
    {
        var DMclient = InitializeDMclient();

        var folderPath = Path.GetDirectoryName(config.SAMPLE_FILE_PATH) ?? throw new ArgumentException($"'{nameof(config.SAMPLE_FILE_PATH)}' is invalid");
        var folders = await DMclient.Helper.GetAllSubFoldersByPathAsync(folderPath);

        Assert.IsNotNull(folders);

    }

    [TestMethod]
    public async Task ShouldReturnFilesWithinFolder()
    {
        var DMclient = InitializeDMclient();

        var folderPath = Path.GetDirectoryName(config.SAMPLE_FILE_PATH) ?? throw new ArgumentException($"'{nameof(config.SAMPLE_FILE_PATH)}' is invalid");
        var files = await DMclient.Helper.GetAllFilesByFolderPathAsync(folderPath);

        Assert.IsNotNull(files);

    }

    [TestMethod]
    public async Task ShouldUploadFileInBucket()
    {

        var DMclient = InitializeDMclient();

        var bucketName = Guid.NewGuid().ToString();

        var newBucket = await DMclient.OssApi.Oss.V2.Buckets.PostAsync(new Autodesk.DataManagement.OSS.Models.Create_buckets_payload() { PolicyKey = Autodesk.DataManagement.OSS.Models.Create_buckets_payload_policyKey.Transient, BucketKey = bucketName });

        //Create a random file content
        var uniqueFileName = $"{Guid.NewGuid()}.txt";

        byte[] byteArray = new byte[11 * 1024];
        var rnd = new Random();
        rnd.NextBytes(byteArray);

        var fileContent = new MemoryStream(byteArray);

        //Upload the file by chunks
        var files = await DMclient.Helper.UploadFileAsync(bucketName, uniqueFileName, fileContent, 50000);

        Assert.IsNotNull(files);

        //Might take few seconds to be really deleted on the server
        await DMclient.OssApi.Oss.V2.Buckets[bucketName].DeleteAsync();
    }

    [TestMethod]
    public async Task ShouldCreateTwoVersionsOfFileInACC()
    {

        var DMclient = InitializeDMclient();

        //Create a random file content
        var uniqueFileName = $"{Guid.NewGuid()}.txt";

        byte[] byteArray = new byte[11 * 1024];
        var rnd = new Random();
        rnd.NextBytes(byteArray);

        var fileContent = new MemoryStream(byteArray);

        //Upload the file by chunks
        var (fileItemId, versionId) = await DMclient.Helper.UploadFileAsync(config.PROJECT_ID, config.FOLDER_ID, uniqueFileName, fileContent, 50000);

        Assert.IsNotNull(fileItemId);
        Assert.IsNotNull(versionId);

        //Upload a new version of the file by chunks
        rnd.NextBytes(byteArray);

        (fileItemId, versionId) = await DMclient.Helper.UploadFileAsync(config.PROJECT_ID, config.FOLDER_ID, uniqueFileName, fileContent, 50000);

        Assert.IsNotNull(fileItemId);
        Assert.IsNotNull(versionId);

        //Might take few seconds to be really deleted on the server
        var projectId = DMclient.Helper.FixProjectId(config.PROJECT_ID);
        await DMclient.DataMgtApi.Data.V1.Projects[projectId].Versions
            .PostAsync(
            new()
            {
                Jsonapi = new()
                {
                    Version = "1.0"
                },
                Data = new()
                {
                    Type = "versions",
                    Attributes = new()
                    {
                        Extension = new()
                        {
                            Type = "versions:autodesk.core:Deleted",
                            Version = "1.0"
                        },
                    },
                    Relationships = new()
                    {
                        Item = new()
                        {
                            Data = new()
                            {
                                Type = "items",
                                Id = fileItemId
                            }
                        }
                    }
                }
            });
    }

    private DataManagementClient InitializeDMclient()
    {

        var proxyClient = Autodesk.Common.HttpClientLibrary.HttpClient.Create();

        proxyClient.BaseAddress = new Uri(PROXY_URL);

        var authClient = new AuthenticationClient(proxyClient);

        var scope = new List<AuthenticationScope>
        {
            AuthenticationScope.BucketCreate,
            AuthenticationScope.BucketDelete,
            AuthenticationScope.DataRead,
            AuthenticationScope.DataCreate,
            AuthenticationScope.DataWrite,
            AuthenticationScope.DataSearch
        };

        async Task<string> getAccessToken()
        {
            var token = await authClient.Helper.GetTwoLeggedToken(config.APS_CLIENT_ID, config.APS_CLIENT_SECRET, scope);

            return token?.AccessToken is null ? throw new InvalidOperationException() : token.AccessToken;
        }

        var DMclient = new DataManagementClient(getAccessToken, proxyClient);

        return DMclient;
    }
}

