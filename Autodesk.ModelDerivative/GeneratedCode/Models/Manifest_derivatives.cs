// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ModelDerivative.Models {
    public class Manifest_derivatives : IParsable 
    {
        /// <summary>The children property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Manifest_derivatives_children>? Children { get; set; }
#nullable restore
#else
        public List<Manifest_derivatives_children> Children { get; set; }
#endif
        /// <summary>The hasThumbnail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HasThumbnail { get; set; }
#nullable restore
#else
        public string HasThumbnail { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The outputType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputType { get; set; }
#nullable restore
#else
        public string OutputType { get; set; }
#endif
        /// <summary>The progress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Progress { get; set; }
#nullable restore
#else
        public string Progress { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Manifest_derivatives"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Manifest_derivatives CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Manifest_derivatives();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"children", n => { Children = n.GetCollectionOfObjectValues<Manifest_derivatives_children>(Manifest_derivatives_children.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasThumbnail", n => { HasThumbnail = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"outputType", n => { OutputType = n.GetStringValue(); } },
                {"progress", n => { Progress = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Manifest_derivatives_children>("children", Children);
            writer.WriteStringValue("hasThumbnail", HasThumbnail);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("outputType", OutputType);
            writer.WriteStringValue("progress", Progress);
            writer.WriteStringValue("status", Status);
        }
    }
}
