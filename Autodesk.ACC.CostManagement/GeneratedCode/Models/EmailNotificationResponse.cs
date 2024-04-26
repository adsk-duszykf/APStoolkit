// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class EmailNotificationResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object ID of the item with which the actions are associated—a budget, contract, or cost item for example.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public EmailNotificationResponse_associationType? AssociationType { get; set; }
        /// <summary>The attachments of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EmailNotificationResponse_attachments>? Attachments { get; set; }
#nullable restore
#else
        public List<EmailNotificationResponse_attachments> Attachments { get; set; }
#endif
        /// <summary>A flag to indicate whether this email should be carbon copy to sender or not.</summary>
        public bool? CopySender { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The ID of the user who created the notification. This is a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>Document ID of the sent history.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentId { get; set; }
#nullable restore
#else
        public string DocumentId { get; set; }
#endif
        /// <summary>Unique identifier of the email sent history.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The message of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The ID of the user who will receive the notification. This is a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Recipient { get; set; }
#nullable restore
#else
        public string Recipient { get; set; }
#endif
        /// <summary>The ID of the user who sent the notification. This is a project user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sender { get; set; }
#nullable restore
#else
        public string Sender { get; set; }
#endif
        /// <summary>Current status of the email.</summary>
        public EmailNotificationResponse_status? Status { get; set; }
        /// <summary>The subject of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="EmailNotificationResponse"/> and sets the default values.
        /// </summary>
        public EmailNotificationResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmailNotificationResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EmailNotificationResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailNotificationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"associationId", n => { AssociationId = n.GetGuidValue(); } },
                {"associationType", n => { AssociationType = n.GetEnumValue<EmailNotificationResponse_associationType>(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<EmailNotificationResponse_attachments>(EmailNotificationResponse_attachments.CreateFromDiscriminatorValue)?.ToList(); } },
                {"copySender", n => { CopySender = n.GetBoolValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"creatorId", n => { CreatorId = n.GetStringValue(); } },
                {"documentId", n => { DocumentId = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"recipient", n => { Recipient = n.GetStringValue(); } },
                {"sender", n => { Sender = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<EmailNotificationResponse_status>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("associationId", AssociationId);
            writer.WriteEnumValue<EmailNotificationResponse_associationType>("associationType", AssociationType);
            writer.WriteCollectionOfObjectValues<EmailNotificationResponse_attachments>("attachments", Attachments);
            writer.WriteBoolValue("copySender", CopySender);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteStringValue("documentId", DocumentId);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("recipient", Recipient);
            writer.WriteStringValue("sender", Sender);
            writer.WriteEnumValue<EmailNotificationResponse_status>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
