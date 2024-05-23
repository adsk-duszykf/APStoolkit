// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.RFIs.Models {
    /// <summary>
    /// Permitted RFI Attribute
    /// </summary>
    public class PermittedRfiAttribute : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the RFI attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The list of possible values for the attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermittedRfiAttribute_values>? Values { get; set; }
#nullable restore
#else
        public List<PermittedRfiAttribute_values> Values { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PermittedRfiAttribute"/> and sets the default values.
        /// </summary>
        public PermittedRfiAttribute()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PermittedRfiAttribute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PermittedRfiAttribute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermittedRfiAttribute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"name", n => { Name = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<PermittedRfiAttribute_values>(PermittedRfiAttribute_values.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<PermittedRfiAttribute_values>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}