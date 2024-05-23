// <auto-generated/>
using Autodesk.ACC.RFIs.Models;
using Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Attachments;
using Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item.Comments;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Autodesk.ACC.RFIs.V2.Containers.Item.Rfis.Item {
    /// <summary>
    /// Builds and executes requests for operations under \v2\containers\{containerId}\rfis\{rfiId}
    /// </summary>
    public class WithRfiItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The attachments property</summary>
        public AttachmentsRequestBuilder Attachments
        {
            get => new AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comments property</summary>
        public CommentsRequestBuilder Comments
        {
            get => new CommentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRfiItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRfiItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/rfis/{rfiId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithRfiItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRfiItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/containers/{containerId}/rfis/{rfiId}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves detailed information about a single RFI (request for information), including the type of workflow roles assigned to the user, whether the user is permitted to create RFIs, which states the user can create the RFIs in, and the attributes that are required when creating the RFIs in the different states. For general information about all the RFIs in a project, see `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.**We strongly recommend calling this endpoint before updating RFIs, in order to verify the most up-to-date permissions and actions.**You can retrieve both document-related (pusphin) RFIs and project-related RFIs.To verify whether an RFI is document-related (pushpin) or project-related, check the ``linkedDocument`` attribute in the response. If the RFI is project-related the ``linkedDocument`` will not have a value, if the RFI is document-related, it will be assigned an ID.RFIs are managed in the `Project Management module`... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="Rfi"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Rfi?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Rfi> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorResponse.CreateFromDiscriminatorValue},
                {"404", ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Rfi>(requestInfo, Rfi.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates an RFI.An RFI in Draft status must be updated by the user who created the RFI. For any other status, an RFI must be updated by the user assigned to the RFI.To verify the statuses that the user can transition the RFI to, the attributes that you are required to specify when transitioning the RFI to the new status, and the potential assignees for each status, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ and check the ``permittedActions`` section. Note that you need to select an assignee when you transition the RFI to another status.The list of permitted transitions that appear in the response payload is dependent on the workflow roles that were assigned to the user and the RFI workflow that was selected for the project.Note that you cannot currently use the RFIs API to assign workflow roles to users. To assign workflow roles, open the Project Admin module, select the Services tab, and select the Project Management section.Note that you cannot currently use the RFIs API to select an RFI workflow type for a project. To assign an RFI workflow to a project, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.For details about statuses and workflow roles, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-EB858EFA-DFEB-47EF-B9B3-1CE75BBE48F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Statuses&gt;`_.**We strongly recommend calling**\  `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_\  **before updating RFIs in order to verify the most up-to-date permissions and actions.**To reassign the RFI to another user in its current status, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_, and check the list of users in the ``permittedActions`` section to see the list of potential assignees.For more details about adding attachments, see the `Transitions tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/rfi-transitions/&gt;`_  `ACC&lt;/en/docs/acc/v1/reference/tutorials/rfi-transitions/&gt;`_ ... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="Rfi"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Rfi?> PatchAsync(UpdateRfiRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Rfi> PatchAsync(UpdateRfiRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorResponse.CreateFromDiscriminatorValue},
                {"404", ErrorResponse.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Rfi>(requestInfo, Rfi.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves detailed information about a single RFI (request for information), including the type of workflow roles assigned to the user, whether the user is permitted to create RFIs, which states the user can create the RFIs in, and the attributes that are required when creating the RFIs in the different states. For general information about all the RFIs in a project, see `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.**We strongly recommend calling this endpoint before updating RFIs, in order to verify the most up-to-date permissions and actions.**You can retrieve both document-related (pusphin) RFIs and project-related RFIs.To verify whether an RFI is document-related (pushpin) or project-related, check the ``linkedDocument`` attribute in the response. If the RFI is project-related the ``linkedDocument`` will not have a value, if the RFI is document-related, it will be assigned an ID.RFIs are managed in the `Project Management module`... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates an RFI.An RFI in Draft status must be updated by the user who created the RFI. For any other status, an RFI must be updated by the user assigned to the RFI.To verify the statuses that the user can transition the RFI to, the attributes that you are required to specify when transitioning the RFI to the new status, and the potential assignees for each status, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ and check the ``permittedActions`` section. Note that you need to select an assignee when you transition the RFI to another status.The list of permitted transitions that appear in the response payload is dependent on the workflow roles that were assigned to the user and the RFI workflow that was selected for the project.Note that you cannot currently use the RFIs API to assign workflow roles to users. To assign workflow roles, open the Project Admin module, select the Services tab, and select the Project Management section.Note that you cannot currently use the RFIs API to select an RFI workflow type for a project. To assign an RFI workflow to a project, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.For details about statuses and workflow roles, see the `RFIs help documentation` `BIM 360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-EB858EFA-DFEB-47EF-B9B3-1CE75BBE48F3&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Statuses&gt;`_.**We strongly recommend calling**\  `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_\  **before updating RFIs in order to verify the most up-to-date permissions and actions.**To reassign the RFI to another user in its current status, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_, and check the list of users in the ``permittedActions`` section to see the list of potential assignees.For more details about adding attachments, see the `Transitions tutorial` `BIM 360&lt;/en/docs/bim360/v1/reference/tutorials/rfi-transitions/&gt;`_  `ACC&lt;/en/docs/acc/v1/reference/tutorials/rfi-transitions/&gt;`_ ... include:: ../../../../_snippets/forward-compatible.rst
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(UpdateRfiRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(UpdateRfiRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithRfiItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithRfiItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithRfiItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithRfiItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithRfiItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}