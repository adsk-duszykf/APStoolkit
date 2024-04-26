// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class DocumentResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object ID of the item with which the actions are associated—a budget, contract, or cost item for example.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public DocumentResponse_associationType? AssociationType { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Error information if this document failed to be generated from the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DocumentResponse_errorInfo? ErrorInfo { get; set; }
#nullable restore
#else
        public DocumentResponse_errorInfo ErrorInfo { get; set; }
#endif
        /// <summary>Unique auto-generated identifier of the generated document.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Internal job sequence used to process the document.</summary>
        public double? JobId { get; set; }
        /// <summary>The version URN of the document with pdf format in the Autodesk Data Management service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PdfUrn { get; set; }
#nullable restore
#else
        public string PdfUrn { get; set; }
#endif
        /// <summary>Autodesk ID of the recipient, who is a project user inside BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientId { get; set; }
#nullable restore
#else
        public string RecipientId { get; set; }
#endif
        /// <summary>Autodesk ID of the person who signed the document, who is a project user inside BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedBy { get; set; }
#nullable restore
#else
        public string SignedBy { get; set; }
#endif
        /// <summary>Current status of the document. Possible values: ``Pending``, ``Started``, ``Completed``, ``Failed``, ``PendingSign``, ``Signed``.</summary>
        public DocumentResponse_status? Status { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The version URN of the document with docx format in the Autodesk Data Management service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DocumentResponse"/> and sets the default values.
        /// </summary>
        public DocumentResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DocumentResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DocumentResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentResponse();
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
                {"associationType", n => { AssociationType = n.GetEnumValue<DocumentResponse_associationType>(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"errorInfo", n => { ErrorInfo = n.GetObjectValue<DocumentResponse_errorInfo>(DocumentResponse_errorInfo.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"jobId", n => { JobId = n.GetDoubleValue(); } },
                {"pdfUrn", n => { PdfUrn = n.GetStringValue(); } },
                {"recipientId", n => { RecipientId = n.GetStringValue(); } },
                {"signedBy", n => { SignedBy = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<DocumentResponse_status>(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
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
            writer.WriteEnumValue<DocumentResponse_associationType>("associationType", AssociationType);
            writer.WriteObjectValue<DocumentResponse_errorInfo>("errorInfo", ErrorInfo);
            writer.WriteDoubleValue("jobId", JobId);
            writer.WriteStringValue("pdfUrn", PdfUrn);
            writer.WriteStringValue("recipientId", RecipientId);
            writer.WriteStringValue("signedBy", SignedBy);
            writer.WriteEnumValue<DocumentResponse_status>("status", Status);
            writer.WriteStringValue("urn", Urn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
