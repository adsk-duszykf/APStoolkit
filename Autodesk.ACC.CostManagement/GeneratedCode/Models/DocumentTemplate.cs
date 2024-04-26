// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class DocumentTemplate : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type of the template is associated to. For example, ``pco``, ``rfq``, ``rco``, ``oco``, ``sco``, ``Payment``, ``BudgetPayment``, ``Contract``, ``MainContract``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>An ID of a user managed by BIM 360 Admin</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangedBy { get; set; }
#nullable restore
#else
        public string ChangedBy { get; set; }
#endif
        /// <summary>Document template belongs to the component template.</summary>
        public Guid? ComponentTemplateId { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The user who created the folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId { get; set; }
#nullable restore
#else
        public string CreatorId { get; set; }
#endif
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DocumentTemplate_errors>? Errors { get; set; }
#nullable restore
#else
        public List<DocumentTemplate_errors> Errors { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; private set; }
        /// <summary>Define if this document template is default template.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Name of the document template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The signatureSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DocumentTemplate_signatureSettings? SignatureSettings { get; set; }
#nullable restore
#else
        public DocumentTemplate_signatureSettings SignatureSettings { get; set; }
#endif
        /// <summary>Type of the document template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>Object Urn of an attachment in Autodesk Data Management service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DocumentTemplate"/> and sets the default values.
        /// </summary>
        public DocumentTemplate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DocumentTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DocumentTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"category", n => { Category = n.GetStringValue(); } },
                {"changedBy", n => { ChangedBy = n.GetStringValue(); } },
                {"componentTemplateId", n => { ComponentTemplateId = n.GetGuidValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"creatorId", n => { CreatorId = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<DocumentTemplate_errors>(DocumentTemplate_errors.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"signatureSettings", n => { SignatureSettings = n.GetObjectValue<DocumentTemplate_signatureSettings>(DocumentTemplate_signatureSettings.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("changedBy", ChangedBy);
            writer.WriteGuidValue("componentTemplateId", ComponentTemplateId);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteCollectionOfObjectValues<DocumentTemplate_errors>("errors", Errors);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<DocumentTemplate_signatureSettings>("signatureSettings", SignatureSettings);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("urn", Urn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
