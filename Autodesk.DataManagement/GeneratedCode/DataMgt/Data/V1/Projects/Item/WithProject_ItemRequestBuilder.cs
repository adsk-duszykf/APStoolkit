// <auto-generated/>
using Autodesk.DataManagement.Data.V1.Projects.Item.Commands;
using Autodesk.DataManagement.Data.V1.Projects.Item.Downloads;
using Autodesk.DataManagement.Data.V1.Projects.Item.Folders;
using Autodesk.DataManagement.Data.V1.Projects.Item.Items;
using Autodesk.DataManagement.Data.V1.Projects.Item.Jobs;
using Autodesk.DataManagement.Data.V1.Projects.Item.Storage;
using Autodesk.DataManagement.Data.V1.Projects.Item.Versions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.DataManagement.Data.V1.Projects.Item {
    /// <summary>
    /// Builds and executes requests for operations under \data\v1\projects\{project_id}
    /// </summary>
    public class WithProject_ItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The commands property</summary>
        public CommandsRequestBuilder Commands
        {
            get => new CommandsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The downloads property</summary>
        public DownloadsRequestBuilder Downloads
        {
            get => new DownloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The folders property</summary>
        public FoldersRequestBuilder Folders
        {
            get => new FoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The items property</summary>
        public ItemsRequestBuilder Items
        {
            get => new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public JobsRequestBuilder Jobs
        {
            get => new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The storage property</summary>
        public StorageRequestBuilder Storage
        {
            get => new StorageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The versions property</summary>
        public VersionsRequestBuilder Versions
        {
            get => new VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithProject_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProject_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithProject_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProject_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}", rawUrl)
        {
        }
    }
}
