// <auto-generated/>
using Autodesk.DataManagement.Projects.Item.Versions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.DataManagement.Projects.Item {
    /// <summary>
    /// Builds and executes requests for operations under \projects\{project_id}
    /// </summary>
    public class WithProject_ItemRequestBuilder : BaseRequestBuilder 
    {
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
        public WithProject_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithProject_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProject_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/{project_id}", rawUrl)
        {
        }
    }
}
