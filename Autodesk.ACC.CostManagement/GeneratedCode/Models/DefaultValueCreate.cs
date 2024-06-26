// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class DefaultValueCreate : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The source of item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>The type of the item with which the item is associated. Possible values: ``Budget``, ``MainContract``, ```BudgetPayment``, ``Contract``, ``CostPayment``,``Expense``, ``CostItem``, ``PCO``,``RFQ``,``RCO``,``OCO``,``SCO``.</summary>
        public DefaultValueCreate_sourceType? SourceType { get; set; }
        /// <summary>The value of the default value definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DefaultValueCreate_value? Value { get; set; }
#nullable restore
#else
        public DefaultValueCreate_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DefaultValueCreate"/> and sets the default values.
        /// </summary>
        public DefaultValueCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DefaultValueCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DefaultValueCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultValueCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"source", n => { Source = n.GetStringValue(); } },
                {"sourceType", n => { SourceType = n.GetEnumValue<DefaultValueCreate_sourceType>(); } },
                {"value", n => { Value = n.GetObjectValue<DefaultValueCreate_value>(DefaultValueCreate_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<DefaultValueCreate_sourceType>("sourceType", SourceType);
            writer.WriteObjectValue<DefaultValueCreate_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
