// <auto-generated/>
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.Association.Approve;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.Calculate;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.Items;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemsBatchCreate;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemsBatchUpdate;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.ItemsBatchUpdateTotalAmount;
using Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item.Rebase;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.Payments.Item {
    /// <summary>
    /// Builds and executes requests for operations under \v1\projects\{projectId}\payments\{id-id}
    /// </summary>
    public class IdItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The associationApprove property</summary>
        public AssociationApproveRequestBuilder AssociationApprove
        {
            get => new AssociationApproveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The calculate property</summary>
        public CalculateRequestBuilder Calculate
        {
            get => new CalculateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The items property</summary>
        public ItemsRequestBuilder Items
        {
            get => new ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The itemsBatchCreate property</summary>
        public ItemsBatchCreateRequestBuilder ItemsBatchCreate
        {
            get => new ItemsBatchCreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The itemsBatchUpdate property</summary>
        public ItemsBatchUpdateRequestBuilder ItemsBatchUpdate
        {
            get => new ItemsBatchUpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The itemsBatchUpdateTotalAmount property</summary>
        public ItemsBatchUpdateTotalAmountRequestBuilder ItemsBatchUpdateTotalAmount
        {
            get => new ItemsBatchUpdateTotalAmountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rebase property</summary>
        public RebaseRequestBuilder Rebase
        {
            get => new RebaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="IdItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments/{id%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IdItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/projects/{projectId}/payments/{id%2Did}", rawUrl)
        {
        }
    }
}
