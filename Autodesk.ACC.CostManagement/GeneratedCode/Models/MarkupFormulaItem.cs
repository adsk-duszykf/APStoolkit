// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class MarkupFormulaItem : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Basis { get; set; }
#nullable restore
#else
        public string Basis { get; set; }
#endif
        /// <summary>The calculations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterExpression>? Calculations { get; set; }
#nullable restore
#else
        public List<FilterExpression> Calculations { get; set; }
#endif
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>``true`` to allow this formula item be edited when the markup formula is applied.``false`` otherwise.</summary>
        public bool? IsVariable { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The position property</summary>
        public double? Position { get; set; }
        /// <summary>The targetBudgetCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetBudgetCode { get; set; }
#nullable restore
#else
        public string TargetBudgetCode { get; set; }
#endif
        /// <summary>The type property</summary>
        public MarkupFormulaItem_type? Type { get; set; }
        /// <summary>The timestamp of the date and time the item was updated, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="MarkupFormulaItem"/> and sets the default values.
        /// </summary>
        public MarkupFormulaItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MarkupFormulaItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MarkupFormulaItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MarkupFormulaItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"amount", n => { Amount = n.GetStringValue(); } },
                {"basis", n => { Basis = n.GetStringValue(); } },
                {"calculations", n => { Calculations = n.GetCollectionOfObjectValues<FilterExpression>(FilterExpression.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isVariable", n => { IsVariable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"position", n => { Position = n.GetDoubleValue(); } },
                {"targetBudgetCode", n => { TargetBudgetCode = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<MarkupFormulaItem_type>(); } },
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
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("basis", Basis);
            writer.WriteCollectionOfObjectValues<FilterExpression>("calculations", Calculations);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isVariable", IsVariable);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("position", Position);
            writer.WriteStringValue("targetBudgetCode", TargetBudgetCode);
            writer.WriteEnumValue<MarkupFormulaItem_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
