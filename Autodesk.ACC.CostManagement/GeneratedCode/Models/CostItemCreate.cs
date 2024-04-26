// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class CostItemCreate : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount approved by the owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Approved { get; set; }
#nullable restore
#else
        public string Approved { get; set; }
#endif
        /// <summary>The ID of the budget that the cost item is linked to.</summary>
        public Guid? BudgetId { get; set; }
        /// <summary>The ID of the change order that the cost item is created in.</summary>
        public Guid? ChangeOrderId { get; set; }
        /// <summary>Amount committed to the supplier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Committed { get; set; }
#nullable restore
#else
        public string Committed { get; set; }
#endif
        /// <summary>Exchange rate for committed amount. Default value is ``1``, if multi-currency is not enabled, it will also be ``1``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommittedExchangeRate { get; set; }
#nullable restore
#else
        public string CommittedExchangeRate { get; set; }
#endif
        /// <summary>Detail description of the cost item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Rough estimation of this item without a quotation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Estimated { get; set; }
#nullable restore
#else
        public string Estimated { get; set; }
#endif
        /// <summary>The input quantity of the cost item.</summary>
        public double? InputQuantity { get; set; }
        /// <summary>Lock state used by ERP integration, default value is ``null``.</summary>
        public CostItemCreate_integrationState? IntegrationState { get; set; }
        /// <summary>The IDs of the locations have been selected and parents of selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? LocationPaths { get; set; }
#nullable restore
#else
        public List<Guid?> LocationPaths { get; set; }
#endif
        /// <summary>The IDs of the locations have been selected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? Locations { get; set; }
#nullable restore
#else
        public List<Guid?> Locations { get; set; }
#endif
        /// <summary>Name of the cost item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Quoted cost of the cost item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Proposed { get; set; }
#nullable restore
#else
        public string Proposed { get; set; }
#endif
        /// <summary>Exchange rate for proposed amount. Default value is ``1``, if multi-currency is not enabled, it will also be ``1``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProposedExchangeRate { get; set; }
#nullable restore
#else
        public string ProposedExchangeRate { get; set; }
#endif
        /// <summary>The quantity of the cost item.</summary>
        public double? Quantity { get; set; }
        /// <summary>Amount sent to the owner for approval.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Submitted { get; set; }
#nullable restore
#else
        public string Submitted { get; set; }
#endif
        /// <summary>The unit of the cost item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CostItemCreate"/> and sets the default values.
        /// </summary>
        public CostItemCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CostItemCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CostItemCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CostItemCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"approved", n => { Approved = n.GetStringValue(); } },
                {"budgetId", n => { BudgetId = n.GetGuidValue(); } },
                {"changeOrderId", n => { ChangeOrderId = n.GetGuidValue(); } },
                {"committed", n => { Committed = n.GetStringValue(); } },
                {"committedExchangeRate", n => { CommittedExchangeRate = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"estimated", n => { Estimated = n.GetStringValue(); } },
                {"inputQuantity", n => { InputQuantity = n.GetDoubleValue(); } },
                {"integrationState", n => { IntegrationState = n.GetEnumValue<CostItemCreate_integrationState>(); } },
                {"locationPaths", n => { LocationPaths = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"locations", n => { Locations = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"proposed", n => { Proposed = n.GetStringValue(); } },
                {"proposedExchangeRate", n => { ProposedExchangeRate = n.GetStringValue(); } },
                {"quantity", n => { Quantity = n.GetDoubleValue(); } },
                {"submitted", n => { Submitted = n.GetStringValue(); } },
                {"unit", n => { Unit = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("approved", Approved);
            writer.WriteGuidValue("budgetId", BudgetId);
            writer.WriteGuidValue("changeOrderId", ChangeOrderId);
            writer.WriteStringValue("committed", Committed);
            writer.WriteStringValue("committedExchangeRate", CommittedExchangeRate);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("estimated", Estimated);
            writer.WriteDoubleValue("inputQuantity", InputQuantity);
            writer.WriteEnumValue<CostItemCreate_integrationState>("integrationState", IntegrationState);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locationPaths", LocationPaths);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locations", Locations);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("proposed", Proposed);
            writer.WriteStringValue("proposedExchangeRate", ProposedExchangeRate);
            writer.WriteDoubleValue("quantity", Quantity);
            writer.WriteStringValue("submitted", Submitted);
            writer.WriteStringValue("unit", Unit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
