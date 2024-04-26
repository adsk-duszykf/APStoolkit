// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    public class Search_data_relationships_thumbnails : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Search_data_relationships_thumbnails_data? Data { get; set; }
#nullable restore
#else
        public Search_data_relationships_thumbnails_data Data { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Search_data_relationships_thumbnails_meta? Meta { get; set; }
#nullable restore
#else
        public Search_data_relationships_thumbnails_meta Meta { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Search_data_relationships_thumbnails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Search_data_relationships_thumbnails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Search_data_relationships_thumbnails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetObjectValue<Search_data_relationships_thumbnails_data>(Search_data_relationships_thumbnails_data.CreateFromDiscriminatorValue); } },
                {"meta", n => { Meta = n.GetObjectValue<Search_data_relationships_thumbnails_meta>(Search_data_relationships_thumbnails_meta.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Search_data_relationships_thumbnails_data>("data", Data);
            writer.WriteObjectValue<Search_data_relationships_thumbnails_meta>("meta", Meta);
        }
    }
}
