// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    public class RelationshipRefs_included_relationships_item : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelationshipRefs_included_relationships_item_data? Data { get; set; }
#nullable restore
#else
        public RelationshipRefs_included_relationships_item_data Data { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelationshipRefs_included_relationships_item_links? Links { get; set; }
#nullable restore
#else
        public RelationshipRefs_included_relationships_item_links Links { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RelationshipRefs_included_relationships_item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RelationshipRefs_included_relationships_item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelationshipRefs_included_relationships_item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetObjectValue<RelationshipRefs_included_relationships_item_data>(RelationshipRefs_included_relationships_item_data.CreateFromDiscriminatorValue); } },
                {"links", n => { Links = n.GetObjectValue<RelationshipRefs_included_relationships_item_links>(RelationshipRefs_included_relationships_item_links.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RelationshipRefs_included_relationships_item_data>("data", Data);
            writer.WriteObjectValue<RelationshipRefs_included_relationships_item_links>("links", Links);
        }
    }
}
