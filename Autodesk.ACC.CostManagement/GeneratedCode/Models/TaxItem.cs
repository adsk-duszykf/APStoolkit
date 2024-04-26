// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class TaxItem : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the tax item.</summary>
        public double? Amount { get; set; }
        /// <summary>The object ID of the object is associated to. For example ID of SOV.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the object is associated to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssociationType { get; set; }
#nullable restore
#else
        public string AssociationType { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Unique auto-generated identifier of the tax item.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Name of the tax item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Position of the tax item.</summary>
        public double? Position { get; set; }
        /// <summary>The tax formula item ID of the tax item.</summary>
        public Guid? TaxFormulaItemId { get; set; }
        /// <summary>Type of the tax item.</summary>
        public TaxItem_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="TaxItem"/> and sets the default values.
        /// </summary>
        public TaxItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TaxItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaxItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaxItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"associationId", n => { AssociationId = n.GetGuidValue(); } },
                {"associationType", n => { AssociationType = n.GetStringValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"position", n => { Position = n.GetDoubleValue(); } },
                {"taxFormulaItemId", n => { TaxFormulaItemId = n.GetGuidValue(); } },
                {"type", n => { Type = n.GetEnumValue<TaxItem_type>(); } },
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
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteGuidValue("associationId", AssociationId);
            writer.WriteStringValue("associationType", AssociationType);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("position", Position);
            writer.WriteGuidValue("taxFormulaItemId", TaxFormulaItemId);
            writer.WriteEnumValue<TaxItem_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
