// <auto-generated/>
using Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Lineages;
using Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties.Parameters;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.ModelProperties.V2.Projects.Item.CustomProperties {
    /// <summary>
    /// Builds and executes requests for operations under \v2\projects\{projectId}\custom-properties
    /// </summary>
    public class CustomPropertiesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The lineages property</summary>
        public LineagesRequestBuilder Lineages
        {
            get => new LineagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The parameters property</summary>
        public ParametersRequestBuilder Parameters
        {
            get => new ParametersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomPropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomPropertiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomPropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomPropertiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/projects/{projectId}/custom-properties", rawUrl)
        {
        }
    }
}
