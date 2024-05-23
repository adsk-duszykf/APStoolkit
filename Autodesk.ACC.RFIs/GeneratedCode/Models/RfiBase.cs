// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    public class RfiBase : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date and time the RFI was answered, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? AnsweredAt { get; set; }
        /// <summary>The Autodesk ID of the user who answered the RFI. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnsweredBy { get; set; }
#nullable restore
#else
        public string AnsweredBy { get; set; }
#endif
        /// <summary>The architectId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchitectId { get; set; }
#nullable restore
#else
        public string ArchitectId { get; set; }
#endif
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The type of assignee. Will always be ``user``.</summary>
        public RfiBase_assignedToType? AssignedToType { get; set; }
        /// <summary>The number of attachments associated with the RFI.</summary>
        public int? AttachmentsCount { get; set; }
        /// <summary>The categories of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? Category { get; set; }
#nullable restore
#else
        public List<Rfis?> Category { get; set; }
#endif
        /// <summary>The date and time the RFI was closed, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The Autodesk ID of the user who closed the RFI. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClosedBy { get; set; }
#nullable restore
#else
        public string ClosedBy { get; set; }
#endif
        /// <summary>The number of comments associated with the RFI.</summary>
        public int? CommentsCount { get; set; }
        /// <summary>The constructionManagerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConstructionManagerId { get; set; }
#nullable restore
#else
        public string ConstructionManagerId { get; set; }
#endif
        /// <summary>The ID of the container.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId { get; set; }
#nullable restore
#else
        public string ContainerId { get; set; }
#endif
        /// <summary>A list of alternative reviewers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewers { get; set; }
#nullable restore
#else
        public List<string> CoReviewers { get; set; }
#endif
        /// <summary>A list of alternative reviewers of role company</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewersCompanies { get; set; }
#nullable restore
#else
        public List<string> CoReviewersCompanies { get; set; }
#endif
        /// <summary>A list of alternative reviewers of role type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CoReviewersRoles { get; set; }
#nullable restore
#else
        public List<string> CoReviewersRoles { get; set; }
#endif
        /// <summary>The cost impact status of the RFI. Possible values: ``null``, ``Yes``, ``No``, ``Unknown``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiCostImpact? CostImpact { get; set; }
#nullable restore
#else
        public RfiCostImpact CostImpact { get; set; }
#endif
        /// <summary>The date and time the RFI was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The Autodesk ID of the user who created the RFI. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>Custom attributes values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? CustomAttributes { get; set; }
#nullable restore
#else
        public List<Rfis?> CustomAttributes { get; set; }
#endif
        /// <summary>The identifier of the RFI given by user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomIdentifier { get; set; }
#nullable restore
#else
        public string CustomIdentifier { get; set; }
#endif
        /// <summary>The disciplines of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Rfis?>? Discipline { get; set; }
#nullable restore
#else
        public List<Rfis?> Discipline { get; set; }
#endif
        /// <summary>The list of users who will be notified of changes to the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionList { get; set; }
#nullable restore
#else
        public List<string> DistributionList { get; set; }
#endif
        /// <summary>The list of companies who will be notified of changes to the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionListCompanies { get; set; }
#nullable restore
#else
        public List<string> DistributionListCompanies { get; set; }
#endif
        /// <summary>The list of roles who will be notified of changes to the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DistributionListRoles { get; set; }
#nullable restore
#else
        public List<string> DistributionListRoles { get; set; }
#endif
        /// <summary>The ID of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The RFI lbs (Location Breakdown Structure) ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? LbsIds { get; set; }
#nullable restore
#else
        public List<string> LbsIds { get; set; }
#endif
        /// <summary>The document ID associated with the RFI. Identifies whether this RFI is a pushpin RFI or a project-related RFI. A pushpin is a visual marker that denotes the location of an RFI in a document. A project-related RFI is assigned a null value, and a pushpin RFI is assigned the item ID of the document associated with the pushpin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedDocument { get; set; }
#nullable restore
#else
        public string LinkedDocument { get; set; }
#endif
        /// <summary>The version of the document when the RFI is closed.</summary>
        public int? LinkedDocumentCloseVersion { get; set; }
        /// <summary>The document version ID associated with the RFI. Only relevant for pushpin RFIs.</summary>
        public int? LinkedDocumentVersion { get; set; }
        /// <summary>The location object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiLocation? Location { get; set; }
#nullable restore
#else
        public RfiLocation Location { get; set; }
#endif
        /// <summary>The managerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerId { get; set; }
#nullable restore
#else
        public string ManagerId { get; set; }
#endif
        /// <summary>An official response for the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficialResponse { get; set; }
#nullable restore
#else
        public string OfficialResponse { get; set; }
#endif
        /// <summary>The priority status of the RFI. Possible values: ``null``, ``High``, ``Normal``, ``Low``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiPriority? Priority { get; set; }
#nullable restore
#else
        public RfiPriority Priority { get; set; }
#endif
        /// <summary>The ID of the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>BIM360: Data about the pushpin RFI. Only relevant for pushpin RFIs. For more details, see the  `RFI pushpin tutorials. &lt;/en/docs/bim360/v1/tutorials/create-pushpin/&gt;`_ACC: Not relevant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiBase_pushpinAttributes? PushpinAttributes { get; set; }
#nullable restore
#else
        public RfiBase_pushpinAttributes PushpinAttributes { get; set; }
#endif
        /// <summary>An external ID; typically used when the RFI was created in another system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reference { get; set; }
#nullable restore
#else
        public string Reference { get; set; }
#endif
        /// <summary>The date and time when the RFI was responded to, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? RespondedAt { get; set; }
        /// <summary>The Autodesk ID of the user who responded to the RFI. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RespondedBy { get; set; }
#nullable restore
#else
        public string RespondedBy { get; set; }
#endif
        /// <summary>The reviewerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewerId { get; set; }
#nullable restore
#else
        public string ReviewerId { get; set; }
#endif
        /// <summary>The ID of the rfi type.</summary>
        public Guid? RfiTypeId { get; set; }
        /// <summary>The schedule impact status of the RFI. Possible values: ``null``, ``Yes``, ``No``, ``Unknown``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RfiScheduleImpact? ScheduleImpact { get; set; }
#nullable restore
#else
        public RfiScheduleImpact ScheduleImpact { get; set; }
#endif
        /// <summary>The status of the RFI. Note that the possible statuses of the RFI depend on the workflow type assigned to the RFI.For a default workflow with a single reviewer (``US``), you can potentially use the following statuses: ``draft``, ``submitted``, ``open``, ``answered``, ``rejected``, ``closed``, ``void``.For a workflow with an additional reviewer (``EMEA``), you can potentially use the following statuses: ``draft``, ``submitted``, ``openRev1``, ``openRev2``, ``rejectedRev1``, ``rejectedManager``, ``answeredRev1``, ``answeredManager``, ``closed``, ``void``.For more information about different workflows and statuses, see the `RFIs help documentation` `BIM360&lt;https://help.autodesk.com/view/BIM360D/ENU/?guid=GUID-787338BF-1189-4170-8629-7FA240F4BED4&gt;`_ `ACC&lt;https://help.autodesk.com/view/BUILD/ENU/?guid=RFI_Workflow_Setup&gt;`_.To check the workflow type of an RFI, call `GET users/me` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-users-me-GET/&gt;`_ and check ``workflow.type``.To check which statuses the user can potentially open the RFI with, call `GET rfis/:id` `BIM 360&lt;/en/docs/bim360/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/rfis-v2-rfis-id-GET&gt;`_.</summary>
        public RfiStatus? Status { get; set; }
        /// <summary>The suggested answer for the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedAnswer { get; set; }
#nullable restore
#else
        public string SuggestedAnswer { get; set; }
#endif
        /// <summary>The name of the RFI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The date and time the RFI was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The Autodesk ID of the user who updated the RFI. To check the name of the user, call `GET projects/users` `BIM 360&lt;/en/docs/bim360/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_ `ACC&lt;/en/docs/acc/v1/reference/http/admin-v1-projects-projectId-users-GET&gt;`_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedBy { get; set; }
#nullable restore
#else
        public string UpdatedBy { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RfiBase"/> and sets the default values.
        /// </summary>
        public RfiBase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RfiBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RfiBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RfiBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"answeredAt", n => { AnsweredAt = n.GetDateTimeOffsetValue(); } },
                {"answeredBy", n => { AnsweredBy = n.GetStringValue(); } },
                {"architectId", n => { ArchitectId = n.GetStringValue(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"assignedToType", n => { AssignedToType = n.GetEnumValue<RfiBase_assignedToType>(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetIntValue(); } },
                {"category", n => { Category = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"closedAt", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                {"closedBy", n => { ClosedBy = n.GetStringValue(); } },
                {"coReviewers", n => { CoReviewers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"coReviewersCompanies", n => { CoReviewersCompanies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"coReviewersRoles", n => { CoReviewersRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"commentsCount", n => { CommentsCount = n.GetIntValue(); } },
                {"constructionManagerId", n => { ConstructionManagerId = n.GetStringValue(); } },
                {"containerId", n => { ContainerId = n.GetStringValue(); } },
                {"costImpact", n => { CostImpact = n.GetObjectValue<RfiCostImpact>(RfiCostImpact.CreateFromDiscriminatorValue); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"customAttributes", n => { CustomAttributes = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"customIdentifier", n => { CustomIdentifier = n.GetStringValue(); } },
                {"discipline", n => { Discipline = n.GetCollectionOfEnumValues<Rfis>()?.ToList(); } },
                {"distributionList", n => { DistributionList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"distributionListCompanies", n => { DistributionListCompanies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"distributionListRoles", n => { DistributionListRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lbsIds", n => { LbsIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"linkedDocument", n => { LinkedDocument = n.GetStringValue(); } },
                {"linkedDocumentCloseVersion", n => { LinkedDocumentCloseVersion = n.GetIntValue(); } },
                {"linkedDocumentVersion", n => { LinkedDocumentVersion = n.GetIntValue(); } },
                {"location", n => { Location = n.GetObjectValue<RfiLocation>(RfiLocation.CreateFromDiscriminatorValue); } },
                {"managerId", n => { ManagerId = n.GetStringValue(); } },
                {"officialResponse", n => { OfficialResponse = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetObjectValue<RfiPriority>(RfiPriority.CreateFromDiscriminatorValue); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"pushpinAttributes", n => { PushpinAttributes = n.GetObjectValue<RfiBase_pushpinAttributes>(RfiBase_pushpinAttributes.CreateFromDiscriminatorValue); } },
                {"reference", n => { Reference = n.GetStringValue(); } },
                {"respondedAt", n => { RespondedAt = n.GetDateTimeOffsetValue(); } },
                {"respondedBy", n => { RespondedBy = n.GetStringValue(); } },
                {"reviewerId", n => { ReviewerId = n.GetStringValue(); } },
                {"rfiTypeId", n => { RfiTypeId = n.GetGuidValue(); } },
                {"scheduleImpact", n => { ScheduleImpact = n.GetObjectValue<RfiScheduleImpact>(RfiScheduleImpact.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<RfiStatus>(); } },
                {"suggestedAnswer", n => { SuggestedAnswer = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"updatedBy", n => { UpdatedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("answeredAt", AnsweredAt);
            writer.WriteStringValue("answeredBy", AnsweredBy);
            writer.WriteStringValue("architectId", ArchitectId);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteEnumValue<RfiBase_assignedToType>("assignedToType", AssignedToType);
            writer.WriteIntValue("attachmentsCount", AttachmentsCount);
            writer.WriteCollectionOfEnumValues<Rfis>("category", Category);
            writer.WriteDateTimeOffsetValue("closedAt", ClosedAt);
            writer.WriteStringValue("closedBy", ClosedBy);
            writer.WriteIntValue("commentsCount", CommentsCount);
            writer.WriteStringValue("constructionManagerId", ConstructionManagerId);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewers", CoReviewers);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersCompanies", CoReviewersCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("coReviewersRoles", CoReviewersRoles);
            writer.WriteObjectValue<RfiCostImpact>("costImpact", CostImpact);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteCollectionOfEnumValues<Rfis>("customAttributes", CustomAttributes);
            writer.WriteStringValue("customIdentifier", CustomIdentifier);
            writer.WriteCollectionOfEnumValues<Rfis>("discipline", Discipline);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionList", DistributionList);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListCompanies", DistributionListCompanies);
            writer.WriteCollectionOfPrimitiveValues<string>("distributionListRoles", DistributionListRoles);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("lbsIds", LbsIds);
            writer.WriteStringValue("linkedDocument", LinkedDocument);
            writer.WriteIntValue("linkedDocumentCloseVersion", LinkedDocumentCloseVersion);
            writer.WriteIntValue("linkedDocumentVersion", LinkedDocumentVersion);
            writer.WriteObjectValue<RfiLocation>("location", Location);
            writer.WriteStringValue("managerId", ManagerId);
            writer.WriteStringValue("officialResponse", OfficialResponse);
            writer.WriteObjectValue<RfiPriority>("priority", Priority);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteObjectValue<RfiBase_pushpinAttributes>("pushpinAttributes", PushpinAttributes);
            writer.WriteStringValue("reference", Reference);
            writer.WriteDateTimeOffsetValue("respondedAt", RespondedAt);
            writer.WriteStringValue("respondedBy", RespondedBy);
            writer.WriteStringValue("reviewerId", ReviewerId);
            writer.WriteGuidValue("rfiTypeId", RfiTypeId);
            writer.WriteObjectValue<RfiScheduleImpact>("scheduleImpact", ScheduleImpact);
            writer.WriteEnumValue<RfiStatus>("status", Status);
            writer.WriteStringValue("suggestedAnswer", SuggestedAnswer);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteStringValue("updatedBy", UpdatedBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}