// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class ActionRespond : IAdditionalDataHolder, IParsable 
    {
        /// <summary>The name of the action performed on the specified item. For example, budgetOpen on a PCO.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The object ID of the item on which the action was performed - a change order (PCO, RCO, OCO, RFQ or SCO) for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssociationId { get; set; }
#nullable restore
#else
        public string AssociationId { get; set; }
#endif
        /// <summary>The type of the item on which the action was performed. Possible values: ``FormInstance``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssociationType { get; set; }
#nullable restore
#else
        public string AssociationType { get; set; }
#endif
        /// <summary>An array of errors that occurred during action execution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DefinedError>? Errors { get; set; }
#nullable restore
#else
        public List<DefinedError> Errors { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ActionRespond"/> and sets the default values.
        /// </summary>
        public ActionRespond()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ActionRespond"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ActionRespond CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionRespond();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetStringValue(); } },
                {"associationId", n => { AssociationId = n.GetStringValue(); } },
                {"associationType", n => { AssociationType = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<DefinedError>(DefinedError.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteStringValue("associationId", AssociationId);
            writer.WriteStringValue("associationType", AssociationType);
            writer.WriteCollectionOfObjectValues<DefinedError>("errors", Errors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
