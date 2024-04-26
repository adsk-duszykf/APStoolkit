// <auto-generated/>
using Autodesk.DataManagement.Data.V1.Projects.Item.Versions.Item.Relationships.Refs;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.DataManagement.Data.V1.Projects.Item.Versions.Item.Relationships {
    /// <summary>
    /// Builds and executes requests for operations under \data\v1\projects\{project_id}\versions\{version_id}\relationships
    /// </summary>
    public class RelationshipsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The refs property</summary>
        public RefsRequestBuilder Refs
        {
            get => new RefsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/versions/{version_id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/data/v1/projects/{project_id}/versions/{version_id}/relationships", rawUrl)
        {
        }
    }
}
