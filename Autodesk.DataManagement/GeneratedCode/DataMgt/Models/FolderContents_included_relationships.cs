// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    public class FolderContents_included_relationships : IParsable 
    {
        /// <summary>The derivatives property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_derivatives? Derivatives { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_derivatives Derivatives { get; set; }
#endif
        /// <summary>The downloadFormats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_downloadFormats? DownloadFormats { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_downloadFormats DownloadFormats { get; set; }
#endif
        /// <summary>The item property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_item? Item { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_item Item { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_links? Links { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_links Links { get; set; }
#endif
        /// <summary>The refs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_refs? Refs { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_refs Refs { get; set; }
#endif
        /// <summary>The storage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_storage? Storage { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_storage Storage { get; set; }
#endif
        /// <summary>The thumbnails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FolderContents_included_relationships_thumbnails? Thumbnails { get; set; }
#nullable restore
#else
        public FolderContents_included_relationships_thumbnails Thumbnails { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FolderContents_included_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FolderContents_included_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FolderContents_included_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"derivatives", n => { Derivatives = n.GetObjectValue<FolderContents_included_relationships_derivatives>(FolderContents_included_relationships_derivatives.CreateFromDiscriminatorValue); } },
                {"downloadFormats", n => { DownloadFormats = n.GetObjectValue<FolderContents_included_relationships_downloadFormats>(FolderContents_included_relationships_downloadFormats.CreateFromDiscriminatorValue); } },
                {"item", n => { Item = n.GetObjectValue<FolderContents_included_relationships_item>(FolderContents_included_relationships_item.CreateFromDiscriminatorValue); } },
                {"links", n => { Links = n.GetObjectValue<FolderContents_included_relationships_links>(FolderContents_included_relationships_links.CreateFromDiscriminatorValue); } },
                {"refs", n => { Refs = n.GetObjectValue<FolderContents_included_relationships_refs>(FolderContents_included_relationships_refs.CreateFromDiscriminatorValue); } },
                {"storage", n => { Storage = n.GetObjectValue<FolderContents_included_relationships_storage>(FolderContents_included_relationships_storage.CreateFromDiscriminatorValue); } },
                {"thumbnails", n => { Thumbnails = n.GetObjectValue<FolderContents_included_relationships_thumbnails>(FolderContents_included_relationships_thumbnails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FolderContents_included_relationships_derivatives>("derivatives", Derivatives);
            writer.WriteObjectValue<FolderContents_included_relationships_downloadFormats>("downloadFormats", DownloadFormats);
            writer.WriteObjectValue<FolderContents_included_relationships_item>("item", Item);
            writer.WriteObjectValue<FolderContents_included_relationships_links>("links", Links);
            writer.WriteObjectValue<FolderContents_included_relationships_refs>("refs", Refs);
            writer.WriteObjectValue<FolderContents_included_relationships_storage>("storage", Storage);
            writer.WriteObjectValue<FolderContents_included_relationships_thumbnails>("thumbnails", Thumbnails);
        }
    }
}
