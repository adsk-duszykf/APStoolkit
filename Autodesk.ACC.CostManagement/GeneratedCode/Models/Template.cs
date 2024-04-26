// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    /// <summary>
    /// The budget code template includes all the segments required by the budget code definition. One project should have only one budget code template.
    /// </summary>
    public class Template : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The ID of the budget code template.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public Template_integrationState? IntegrationState { get; set; }
        /// <summary>The date and time last locked this item.</summary>
        public DateTimeOffset? IntegrationStateChangedAt { get; set; }
        /// <summary>The user who last locked this item. This is the ID of a user managed by BIM 360 Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegrationStateChangedBy { get; set; }
#nullable restore
#else
        public string IntegrationStateChangedBy { get; set; }
#endif
        /// <summary>The lock status of template.</summary>
        public bool? Locked { get; set; }
        /// <summary>The name of the budget code template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="Template"/> and sets the default values.
        /// </summary>
        public Template()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Template"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Template CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Template();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"integrationState", n => { IntegrationState = n.GetEnumValue<Template_integrationState>(); } },
                {"integrationStateChangedAt", n => { IntegrationStateChangedAt = n.GetDateTimeOffsetValue(); } },
                {"integrationStateChangedBy", n => { IntegrationStateChangedBy = n.GetStringValue(); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteEnumValue<Template_integrationState>("integrationState", IntegrationState);
            writer.WriteDateTimeOffsetValue("integrationStateChangedAt", IntegrationStateChangedAt);
            writer.WriteStringValue("integrationStateChangedBy", IntegrationStateChangedBy);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
