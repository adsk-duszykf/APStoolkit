// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    /// <summary>
    /// Successful retrieval of a specific item.
    /// </summary>
    public class Item : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Item_data? Data { get; set; }
#nullable restore
#else
        public Item_data Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Item_included>? Included { get; set; }
#nullable restore
#else
        public List<Item_included> Included { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Item_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public Item_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Item_links? Links { get; set; }
#nullable restore
#else
        public Item_links Links { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetObjectValue<Item_data>(Item_data.CreateFromDiscriminatorValue); } },
                {"included", n => { Included = n.GetCollectionOfObjectValues<Item_included>(Item_included.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<Item_jsonapi>(Item_jsonapi.CreateFromDiscriminatorValue); } },
                {"links", n => { Links = n.GetObjectValue<Item_links>(Item_links.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Item_data>("data", Data);
            writer.WriteCollectionOfObjectValues<Item_included>("included", Included);
            writer.WriteObjectValue<Item_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<Item_links>("links", Links);
        }
    }
}
