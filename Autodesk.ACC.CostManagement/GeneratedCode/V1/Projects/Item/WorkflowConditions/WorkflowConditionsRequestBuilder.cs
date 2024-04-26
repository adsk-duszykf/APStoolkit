// <auto-generated/>
using Autodesk.ACC.CostManagement.Models;
using Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.WorkflowConditions {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\workflow-conditions
    /// </summary>
    public class WorkflowConditionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.workflowConditions.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="WorkflowConditionsItemRequestBuilder"/></returns>
        public WorkflowConditionsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new WorkflowConditionsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Autodesk.ACC.CostManagement.v1.projects.item.workflowConditions.item collection</summary>
        /// <param name="position">The object ID of the item.</param>
        /// <returns>A <see cref="WorkflowConditionsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WorkflowConditionsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new WorkflowConditionsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowConditionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowConditionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/workflow-conditions?associationType={associationType}{&internalLimit*,limit*,offset*,sort*,workflowDefinitionId*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowConditionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowConditionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/workflow-conditions?associationType={associationType}{&internalLimit*,limit*,offset*,sort*,workflowDefinitionId*}", rawUrl)
        {
        }
        /// <summary>
        /// Gets all the workflow conditions for an association type.
        /// </summary>
        /// <returns>A List&lt;WorkflowCondition&gt;</returns>
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
        public async Task<List<WorkflowCondition>?> GetAsync(Action<RequestConfiguration<WorkflowConditionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<WorkflowCondition>> GetAsync(Action<RequestConfiguration<WorkflowConditionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            var collectionResult = await RequestAdapter.SendCollectionAsync<WorkflowCondition>(requestInfo, WorkflowCondition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a new workflow condition for an association type.
        /// </summary>
        /// <returns>A <see cref="WorkflowCondition"/></returns>
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
        public async Task<WorkflowCondition?> PostAsync(WorkflowConditionCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WorkflowCondition> PostAsync(WorkflowConditionCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<WorkflowCondition>(requestInfo, WorkflowCondition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets all the workflow conditions for an association type.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowConditionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowConditionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new workflow condition for an association type.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WorkflowConditionCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WorkflowConditionCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/v1/projects/{projectId}/workflow-conditions", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WorkflowConditionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WorkflowConditionsRequestBuilder WithUrl(string rawUrl)
        {
            return new WorkflowConditionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets all the workflow conditions for an association type.
        /// </summary>
        public class WorkflowConditionsRequestBuilderGetQueryParameters 
        {
            /// <summary>The type of the item is associated to. Possible values ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, ``Payment``, ``BudgetPayment``, ``Expense``, ``OCO``, ``SCO``.</summary>
            [Obsolete("This property is deprecated, use AssociationTypeAsGetAssociationTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("associationType")]
            public string? AssociationType { get; set; }
#nullable restore
#else
            [QueryParameter("associationType")]
            public string AssociationType { get; set; }
#endif
            /// <summary>The type of the item is associated to. Possible values ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, ``Payment``, ``BudgetPayment``, ``Expense``, ``OCO``, ``SCO``.</summary>
            [QueryParameter("associationType")]
            public GetAssociationTypeQueryParameterType? AssociationTypeAsGetAssociationTypeQueryParameterType { get; set; }
            /// <summary>The maximum number of items to return, this is for internal use, and the default maximum internal limit is 5000.</summary>
            [QueryParameter("internalLimit")]
            public int? InternalLimit { get; set; }
            /// <summary>The maximum number of items to return, default maximum limit is 100.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>The number of items to skip before starting to collect the result set.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
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
            /// <summary>The related workflow definition id.</summary>
            [QueryParameter("workflowDefinitionId")]
            public Guid? WorkflowDefinitionId { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkflowConditionsRequestBuilderGetRequestConfiguration : RequestConfiguration<WorkflowConditionsRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkflowConditionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
