// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class TaxFormulaItem : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the tax formula item.</summary>
        public double? Amount { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Name of the tax formula item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Position of the tax formula item.</summary>
        public double? Position { get; set; }
        /// <summary>Type of the tax formula item.</summary>
        public TaxFormulaItem_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="TaxFormulaItem"/> and sets the default values.
        /// </summary>
        public TaxFormulaItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TaxFormulaItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaxFormulaItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaxFormulaItem();
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
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"position", n => { Position = n.GetDoubleValue(); } },
                {"type", n => { Type = n.GetEnumValue<TaxFormulaItem_type>(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("position", Position);
            writer.WriteEnumValue<TaxFormulaItem_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
