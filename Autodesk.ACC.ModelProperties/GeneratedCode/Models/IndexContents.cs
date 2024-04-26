// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.ModelProperties.Models {
    /// <summary>
    /// Parameters to control content within the Index
    /// </summary>
    public class IndexContents : IParsable 
    {
        /// <summary>composite handling/filtering mode</summary>
        public Autodesk.ACC.ModelProperties.Models.CompositeMode? CompositeMode { get; set; }
        /// <summary>Whether to include &quot;Custom Properties&quot; in the Index. Set to false or omit if Custom Properties not required since that will affect Index performance. Setting to &apos;true&apos; implicitly sets &apos;visibleItemsOnly&apos; to &apos;true&apos;.</summary>
        public bool? IncludeCustomProperties { get; set; }
        /// <summary>Whether to limit the Index to only &quot;3D visible&quot; items. Recommended when possible to improve Index and Query performance.</summary>
        public bool? VisibleItemsOnly { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IndexContents"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IndexContents CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndexContents();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"compositeMode", n => { CompositeMode = n.GetEnumValue<CompositeMode>(); } },
                {"includeCustomProperties", n => { IncludeCustomProperties = n.GetBoolValue(); } },
                {"visibleItemsOnly", n => { VisibleItemsOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CompositeMode>("compositeMode", CompositeMode);
            writer.WriteBoolValue("includeCustomProperties", IncludeCustomProperties);
            writer.WriteBoolValue("visibleItemsOnly", VisibleItemsOnly);
        }
    }
}
