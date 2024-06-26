// <auto-generated/>
using Autodesk.DataManagement.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.DataManagement.Data.V1.Projects.Item.Versions.Item.Downloads {
    /// <summary>
    /// Builds and executes requests for operations under \data\v1\projects\{project_id}\versions\{version_id}\downloads
    /// </summary>
    public class DownloadsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/versions/{version_id}/downloads{?filter%5Bformat%2EfileType%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DownloadsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DownloadsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/versions/{version_id}/downloads{?filter%5Bformat%2EfileType%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a set of already available downloads for this version.
        /// </summary>
        /// <returns>A <see cref="Autodesk.DataManagement.Models.Downloads"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Downloads400Error">When receiving a 400 status code</exception>
        /// <exception cref="Downloads403Error">When receiving a 403 status code</exception>
        /// <exception cref="Downloads404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Autodesk.DataManagement.Models.Downloads?> GetAsync(Action<RequestConfiguration<DownloadsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Autodesk.DataManagement.Models.Downloads> GetAsync(Action<RequestConfiguration<DownloadsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", Downloads400Error.CreateFromDiscriminatorValue},
                {"403", Downloads403Error.CreateFromDiscriminatorValue},
                {"404", Downloads404Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Autodesk.DataManagement.Models.Downloads>(requestInfo, Autodesk.DataManagement.Models.Downloads.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a set of already available downloads for this version.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DownloadsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DownloadsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DownloadsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DownloadsRequestBuilder WithUrl(string rawUrl)
        {
            return new DownloadsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a set of already available downloads for this version.
        /// </summary>
        public class DownloadsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by the file type of the download object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bformat%2EfileType%5D")]
            public string[]? FilterformatFileType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bformat%2EfileType%5D")]
            public string[] FilterformatFileType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DownloadsRequestBuilderGetRequestConfiguration : RequestConfiguration<DownloadsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
