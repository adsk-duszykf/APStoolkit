// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ModelDerivative.Models {
    public class Manifest : IParsable 
    {
        /// <summary>The derivatives property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Manifest_derivatives>? Derivatives { get; set; }
#nullable restore
#else
        public List<Manifest_derivatives> Derivatives { get; set; }
#endif
        /// <summary>The hasThumbnail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HasThumbnail { get; set; }
#nullable restore
#else
        public string HasThumbnail { get; set; }
#endif
        /// <summary>The progress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Progress { get; set; }
#nullable restore
#else
        public string Progress { get; set; }
#endif
        /// <summary>The region property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The urn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Manifest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Manifest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Manifest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"derivatives", n => { Derivatives = n.GetCollectionOfObjectValues<Manifest_derivatives>(Manifest_derivatives.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasThumbnail", n => { HasThumbnail = n.GetStringValue(); } },
                {"progress", n => { Progress = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Manifest_derivatives>("derivatives", Derivatives);
            writer.WriteStringValue("hasThumbnail", HasThumbnail);
            writer.WriteStringValue("progress", Progress);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("urn", Urn);
            writer.WriteStringValue("version", Version);
        }
    }
}
