// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class GeneralSettings : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The architectCompanyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchitectCompanyId { get; set; }
#nullable restore
#else
        public string ArchitectCompanyId { get; set; }
#endif
        /// <summary>The budgetLock property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetLock { get; set; }
#nullable restore
#else
        public string BudgetLock { get; set; }
#endif
        /// <summary>The budgetLockedAt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetLockedAt { get; set; }
#nullable restore
#else
        public string BudgetLockedAt { get; set; }
#endif
        /// <summary>The budgetLockedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BudgetLockedBy { get; set; }
#nullable restore
#else
        public string BudgetLockedBy { get; set; }
#endif
        /// <summary>The gcCompanyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GcCompanyId { get; set; }
#nullable restore
#else
        public string GcCompanyId { get; set; }
#endif
        /// <summary>The ownerCompanyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerCompanyId { get; set; }
#nullable restore
#else
        public string OwnerCompanyId { get; set; }
#endif
        /// <summary>The responseDueDays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResponseDueDays { get; set; }
#nullable restore
#else
        public string ResponseDueDays { get; set; }
#endif
        /// <summary>The unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GeneralSettings"/> and sets the default values.
        /// </summary>
        public GeneralSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GeneralSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GeneralSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GeneralSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"architectCompanyId", n => { ArchitectCompanyId = n.GetStringValue(); } },
                {"budgetLock", n => { BudgetLock = n.GetStringValue(); } },
                {"budgetLockedAt", n => { BudgetLockedAt = n.GetStringValue(); } },
                {"budgetLockedBy", n => { BudgetLockedBy = n.GetStringValue(); } },
                {"gcCompanyId", n => { GcCompanyId = n.GetStringValue(); } },
                {"ownerCompanyId", n => { OwnerCompanyId = n.GetStringValue(); } },
                {"responseDueDays", n => { ResponseDueDays = n.GetStringValue(); } },
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
            writer.WriteStringValue("architectCompanyId", ArchitectCompanyId);
            writer.WriteStringValue("budgetLock", BudgetLock);
            writer.WriteStringValue("budgetLockedAt", BudgetLockedAt);
            writer.WriteStringValue("budgetLockedBy", BudgetLockedBy);
            writer.WriteStringValue("gcCompanyId", GcCompanyId);
            writer.WriteStringValue("ownerCompanyId", OwnerCompanyId);
            writer.WriteStringValue("responseDueDays", ResponseDueDays);
            writer.WriteStringValue("unit", Unit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
