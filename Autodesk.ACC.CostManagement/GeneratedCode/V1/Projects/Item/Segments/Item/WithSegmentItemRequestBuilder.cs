// <auto-generated/>
using Autodesk.ACC.CostManagement.V1.Projects.Item.Segments.Item.Values;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Segments.Item.ValuesImport;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Segments.Item {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\segments\{segmentId}
    /// </summary>
    public class WithSegmentItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The values property</summary>
        public ValuesRequestBuilder Values
        {
            get => new ValuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The valuesImport property</summary>
        public ValuesImportRequestBuilder ValuesImport
        {
            get => new ValuesImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSegmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSegmentItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/segments/{segmentId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSegmentItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSegmentItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/segments/{segmentId}", rawUrl)
        {
        }
    }
}
