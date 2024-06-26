// <auto-generated/>
using Autodesk.ACC.CostManagement.V1.Projects.Item.Options.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Options {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\options
    /// </summary>
    public class OptionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.options.item collection</summary>
        /// <param name="position">Topic of options.</param>
        /// <returns>A <see cref="WithTopicItemRequestBuilder"/></returns>
        public WithTopicItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("topic", position);
                return new WithTopicItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="OptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/options", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="OptionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/options", rawUrl)
        {
        }
    }
}
