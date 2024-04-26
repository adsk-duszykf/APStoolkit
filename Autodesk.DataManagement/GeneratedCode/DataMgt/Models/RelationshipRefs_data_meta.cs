// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    public class RelationshipRefs_data_meta : IParsable 
    {
        /// <summary>The direction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Direction { get; set; }
#nullable restore
#else
        public string Direction { get; set; }
#endif
        /// <summary>The extension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelationshipRefs_data_meta_extension? Extension { get; set; }
#nullable restore
#else
        public RelationshipRefs_data_meta_extension Extension { get; set; }
#endif
        /// <summary>The fromId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromId { get; set; }
#nullable restore
#else
        public string FromId { get; set; }
#endif
        /// <summary>The fromType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromType { get; set; }
#nullable restore
#else
        public string FromType { get; set; }
#endif
        /// <summary>The refType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefType { get; set; }
#nullable restore
#else
        public string RefType { get; set; }
#endif
        /// <summary>The toId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToId { get; set; }
#nullable restore
#else
        public string ToId { get; set; }
#endif
        /// <summary>The toType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToType { get; set; }
#nullable restore
#else
        public string ToType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RelationshipRefs_data_meta"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RelationshipRefs_data_meta CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelationshipRefs_data_meta();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"direction", n => { Direction = n.GetStringValue(); } },
                {"extension", n => { Extension = n.GetObjectValue<RelationshipRefs_data_meta_extension>(RelationshipRefs_data_meta_extension.CreateFromDiscriminatorValue); } },
                {"fromId", n => { FromId = n.GetStringValue(); } },
                {"fromType", n => { FromType = n.GetStringValue(); } },
                {"refType", n => { RefType = n.GetStringValue(); } },
                {"toId", n => { ToId = n.GetStringValue(); } },
                {"toType", n => { ToType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("direction", Direction);
            writer.WriteObjectValue<RelationshipRefs_data_meta_extension>("extension", Extension);
            writer.WriteStringValue("fromId", FromId);
            writer.WriteStringValue("fromType", FromType);
            writer.WriteStringValue("refType", RefType);
            writer.WriteStringValue("toId", ToId);
            writer.WriteStringValue("toType", ToType);
        }
    }
}
