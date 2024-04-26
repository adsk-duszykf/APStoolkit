// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class PerformanceTrackingItemInstanceUpdate : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The adjusted output quantity of the performance tracking item instance.</summary>
        public double? AdjustedOutputQuantity { get; set; }
        /// <summary>The code of the budget to which the performance tracking item instance belongs. Alternative to ``budgetId```.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetCode { get; private set; }
#nullable restore
#else
        public string BudgetCode { get; private set; }
#endif
        /// <summary>The unique identifier of the budget to which the performance tracking item instance belongs.</summary>
        public Guid? BudgetId { get; private set; }
        /// <summary>The input quantity of the performance tracking item instance.</summary>
        public double? InputQuantity { get; set; }
        /// <summary>The unit of the input of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputUnit { get; set; }
#nullable restore
#else
        public string InputUnit { get; set; }
#endif
        /// <summary>The unit price of the input of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputUnitPrice { get; set; }
#nullable restore
#else
        public string InputUnitPrice { get; set; }
#endif
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
        /// <summary>The locked performance tracking item instance field. You can lock the performance tracking item instance&apos;s planned total (``plannedTotal``) when calculating a item instance if you&apos;re updating a single value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockedFields { get; set; }
#nullable restore
#else
        public string LockedFields { get; set; }
#endif
        /// <summary>The name of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The number of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; set; }
#nullable restore
#else
        public string Number { get; set; }
#endif
        /// <summary>The output quantity of the performance tracking item instance.</summary>
        public double? OutputQuantity { get; set; }
        /// <summary>The unit of the output of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputUnit { get; set; }
#nullable restore
#else
        public string OutputUnit { get; set; }
#endif
        /// <summary>The unit price of the output of the performance tracking item instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputUnitPrice { get; set; }
#nullable restore
#else
        public string OutputUnitPrice { get; set; }
#endif
        /// <summary>The tracked input quantity of the performance tracking item instance.</summary>
        public double? TrackedInputQuantity { get; set; }
        /// <summary>The tracked output quantity of the performance tracking item instance.</summary>
        public double? TrackedOutputQuantity { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PerformanceTrackingItemInstanceUpdate"/> and sets the default values.
        /// </summary>
        public PerformanceTrackingItemInstanceUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PerformanceTrackingItemInstanceUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PerformanceTrackingItemInstanceUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PerformanceTrackingItemInstanceUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"adjustedOutputQuantity", n => { AdjustedOutputQuantity = n.GetDoubleValue(); } },
                {"budgetCode", n => { BudgetCode = n.GetStringValue(); } },
                {"budgetId", n => { BudgetId = n.GetGuidValue(); } },
                {"inputQuantity", n => { InputQuantity = n.GetDoubleValue(); } },
                {"inputUnit", n => { InputUnit = n.GetStringValue(); } },
                {"inputUnitPrice", n => { InputUnitPrice = n.GetStringValue(); } },
                {"locationPaths", n => { LocationPaths = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"locations", n => { Locations = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"lockedFields", n => { LockedFields = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"outputQuantity", n => { OutputQuantity = n.GetDoubleValue(); } },
                {"outputUnit", n => { OutputUnit = n.GetStringValue(); } },
                {"outputUnitPrice", n => { OutputUnitPrice = n.GetStringValue(); } },
                {"trackedInputQuantity", n => { TrackedInputQuantity = n.GetDoubleValue(); } },
                {"trackedOutputQuantity", n => { TrackedOutputQuantity = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("adjustedOutputQuantity", AdjustedOutputQuantity);
            writer.WriteDoubleValue("inputQuantity", InputQuantity);
            writer.WriteStringValue("inputUnit", InputUnit);
            writer.WriteStringValue("inputUnitPrice", InputUnitPrice);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locationPaths", LocationPaths);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("locations", Locations);
            writer.WriteStringValue("lockedFields", LockedFields);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("number", Number);
            writer.WriteDoubleValue("outputQuantity", OutputQuantity);
            writer.WriteStringValue("outputUnit", OutputUnit);
            writer.WriteStringValue("outputUnitPrice", OutputUnitPrice);
            writer.WriteDoubleValue("trackedInputQuantity", TrackedInputQuantity);
            writer.WriteDoubleValue("trackedOutputQuantity", TrackedOutputQuantity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
