// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class DistributionColumn : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total planned amount for distribution column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The object ID of the item with which the actions are associated—a budget, contract, or cost item for example.</summary>
        public Guid? AssociationId { get; set; }
        /// <summary>The type of the item is associated to. For example, ``Budget``, ``Contract``, ``CostItem``, ``FormInstance``, and ``Payment``, ``MainContract``, ``BudgetPayment``, ``Expense``, ``ExpenseItem``, ``OCO``, ``SCO`` in the coming release.</summary>
        public DistributionColumn_associationType? AssociationType { get; set; }
        /// <summary>The ID of budget.</summary>
        public Guid? BudgetId { get; set; }
        /// <summary>The timestamp of the date and time the item was created, in the following format: YYYY-MM-DDThh:mm:ss.sz.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>Forecast Distribution Date of distribution column.</summary>
        public DateTimeOffset? ForecastDistributionAt { get; private set; }
        /// <summary>Unique identifier of the distribution column.</summary>
        public Guid? Id { get; set; }
        /// <summary>The name of distribution column.</summary>
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
        /// Instantiates a new <see cref="DistributionColumn"/> and sets the default values.
        /// </summary>
        public DistributionColumn()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DistributionColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DistributionColumn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DistributionColumn();
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
                {"associationId", n => { AssociationId = n.GetGuidValue(); } },
                {"associationType", n => { AssociationType = n.GetEnumValue<DistributionColumn_associationType>(); } },
                {"budgetId", n => { BudgetId = n.GetGuidValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"forecastDistributionAt", n => { ForecastDistributionAt = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
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
            writer.WriteStringValue("amount", Amount);
            writer.WriteGuidValue("associationId", AssociationId);
            writer.WriteEnumValue<DistributionColumn_associationType>("associationType", AssociationType);
            writer.WriteGuidValue("budgetId", BudgetId);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
