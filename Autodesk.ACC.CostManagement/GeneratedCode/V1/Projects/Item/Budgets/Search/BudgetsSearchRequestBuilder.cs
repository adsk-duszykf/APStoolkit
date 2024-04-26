// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Budgets.Search {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\budgets\:search
    /// </summary>
    public class BudgetsSearchRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="BudgetsSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BudgetsSearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/budgets/:search{?cursorState*,internalLimit*,limit*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BudgetsSearchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BudgetsSearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/budgets/:search{?cursorState*,internalLimit*,limit*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        /// <returns>A <see cref="BudgetListResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="DefinedError">When receiving a 400 status code</exception>
        /// <exception cref="Error">When receiving a 401 status code</exception>
        /// <exception cref="Error">When receiving a 403 status code</exception>
        /// <exception cref="Error">When receiving a 404 status code</exception>
        /// <exception cref="Error">When receiving a 500 status code</exception>
        /// <exception cref="Error">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BudgetListResponse?> PostAsync(BudgetsSearchPostRequestBody body, Action<RequestConfiguration<BudgetsSearchRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<BudgetListResponse> PostAsync(BudgetsSearchPostRequestBody body, Action<RequestConfiguration<BudgetsSearchRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BudgetListResponse>(requestInfo, BudgetListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(BudgetsSearchPostRequestBody body, Action<RequestConfiguration<BudgetsSearchRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(BudgetsSearchPostRequestBody body, Action<RequestConfiguration<BudgetsSearchRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="BudgetsSearchRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BudgetsSearchRequestBuilder WithUrl(string rawUrl)
        {
            return new BudgetsSearchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all the budgets in a specific project.
        /// </summary>
        public class BudgetsSearchRequestBuilderPostQueryParameters 
        {
            /// <summary>The cursor token to get the next page of results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("cursorState")]
            public string? CursorState { get; set; }
#nullable restore
#else
            [QueryParameter("cursorState")]
            public string CursorState { get; set; }
#endif
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The sort order for items. Each attribute can be sorted in either ``asc`` (default) or ``desc`` order. For example, ``sort=name, updatedAt desc`` or ``sort=name + updatedAt desc`` sorts the results first by name in ascending order, then by date updated in descending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BudgetsSearchRequestBuilderPostRequestConfiguration : RequestConfiguration<BudgetsSearchRequestBuilderPostQueryParameters> 
        {
        }
    }
}
