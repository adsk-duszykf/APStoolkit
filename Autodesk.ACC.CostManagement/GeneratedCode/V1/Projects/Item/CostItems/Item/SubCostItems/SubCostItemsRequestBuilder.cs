// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.CostItems.Item.SubCostItems.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.CostItems.Item.SubCostItems {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\cost-items\{costItemId}\sub-cost-items
    /// </summary>
    public class SubCostItemsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.costItems.item.subCostItems.item collection</summary>
        /// <param name="position">Id of the ``SubCostItems`` item.</param>
        /// <returns>A <see cref="WithSubCostItemsItemRequestBuilder"/></returns>
        public WithSubCostItemsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("subCostItemsId", position);
                return new WithSubCostItemsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="SubCostItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubCostItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/cost-items/{costItemId}/sub-cost-items{?filter%5Btype%5D*,internalLimit*,limit*,offset*,scope*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SubCostItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SubCostItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/cost-items/{costItemId}/sub-cost-items{?filter%5Btype%5D*,internalLimit*,limit*,offset*,scope*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all the ``SubCostItem`` in a given CostItem
        /// </summary>
        /// <returns>A List&lt;SubCostItem&gt;</returns>
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
        public async Task<List<SubCostItem>?> GetAsync(Action<RequestConfiguration<SubCostItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<SubCostItem>> GetAsync(Action<RequestConfiguration<SubCostItemsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", DefinedError.CreateFromDiscriminatorValue},
                {"401", Error.CreateFromDiscriminatorValue},
                {"403", Error.CreateFromDiscriminatorValue},
                {"404", Error.CreateFromDiscriminatorValue},
                {"500", Error.CreateFromDiscriminatorValue},
                {"503", Error.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<SubCostItem>(requestInfo, SubCostItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a ``SubCostItem`` in a specific project.
        /// </summary>
        /// <returns>A <see cref="SubCostItem"/></returns>
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
        public async Task<SubCostItem?> PostAsync(SubCostItemCreate body, Action<RequestConfiguration<SubCostItemsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<SubCostItem> PostAsync(SubCostItemCreate body, Action<RequestConfiguration<SubCostItemsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<SubCostItem>(requestInfo, SubCostItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all the ``SubCostItem`` in a given CostItem
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SubCostItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SubCostItemsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a ``SubCostItem`` in a specific project.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(SubCostItemCreate body, Action<RequestConfiguration<SubCostItemsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(SubCostItemCreate body, Action<RequestConfiguration<SubCostItemsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/v1/projects/{projectId}/cost-items/{costItemId}/sub-cost-items{?scope*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="SubCostItemsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SubCostItemsRequestBuilder WithUrl(string rawUrl)
        {
            return new SubCostItemsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all the ``SubCostItem`` in a given CostItem
        /// </summary>
        public class SubCostItemsRequestBuilderGetQueryParameters 
        {
            /// <summary>The type of the value to break down.</summary>
            [Obsolete("This property is deprecated, use FiltertypeAsGetFilterTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string Filtertype { get; set; }
#endif
            /// <summary>The type of the value to break down.</summary>
            [QueryParameter("filter%5Btype%5D")]
            public GetFilterTypeQueryParameterType? FiltertypeAsGetFilterTypeQueryParameterType { get; set; }
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>The scope of the cost item, usually by change order type.</summary>
            [Obsolete("This property is deprecated, use ScopeAsGetScopeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
            /// <summary>The scope of the cost item, usually by change order type.</summary>
            [QueryParameter("scope")]
            public GetScopeQueryParameterType? ScopeAsGetScopeQueryParameterType { get; set; }
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
        public class SubCostItemsRequestBuilderGetRequestConfiguration : RequestConfiguration<SubCostItemsRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Creates a ``SubCostItem`` in a specific project.
        /// </summary>
        public class SubCostItemsRequestBuilderPostQueryParameters 
        {
            /// <summary>The scope of the cost item, usually by change order type.</summary>
            [Obsolete("This property is deprecated, use ScopeAsPostScopeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
            /// <summary>The scope of the cost item, usually by change order type.</summary>
            [QueryParameter("scope")]
            public PostScopeQueryParameterType? ScopeAsPostScopeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SubCostItemsRequestBuilderPostRequestConfiguration : RequestConfiguration<SubCostItemsRequestBuilderPostQueryParameters> 
        {
        }
    }
}
