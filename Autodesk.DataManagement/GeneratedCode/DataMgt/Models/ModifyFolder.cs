// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    /// <summary>
    /// Modifies folder names
    /// </summary>
    public class ModifyFolder : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ModifyFolder_data? Data { get; set; }
#nullable restore
#else
        public ModifyFolder_data Data { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ModifyFolder_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public ModifyFolder_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ModifyFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ModifyFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ModifyFolder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetObjectValue<ModifyFolder_data>(ModifyFolder_data.CreateFromDiscriminatorValue); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<ModifyFolder_jsonapi>(ModifyFolder_jsonapi.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ModifyFolder_data>("data", Data);
            writer.WriteObjectValue<ModifyFolder_jsonapi>("jsonapi", Jsonapi);
        }
    }
}
