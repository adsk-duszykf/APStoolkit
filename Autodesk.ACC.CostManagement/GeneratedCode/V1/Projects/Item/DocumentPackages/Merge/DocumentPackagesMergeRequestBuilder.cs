// <auto-generated/>
using Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Merge.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.DocumentPackages.Merge {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\document-packages\:merge
    /// </summary>
    public class DocumentPackagesMergeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.documentPackages.Merge.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="MergeItemRequestBuilder"/></returns>
        public MergeItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new MergeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.documentPackages.Merge.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="MergeItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public MergeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new MergeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="DocumentPackagesMergeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentPackagesMergeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/document-packages/:merge", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DocumentPackagesMergeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentPackagesMergeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/document-packages/:merge", rawUrl)
        {
        }
    }
}
