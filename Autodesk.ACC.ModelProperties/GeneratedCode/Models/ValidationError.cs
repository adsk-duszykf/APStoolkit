// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.ModelProperties.Models {
    /// <summary>
    /// An error associated with a validation problem
    /// </summary>
    public class ValidationError : IParsable 
    {
        /// <summary>A more detailed, human readable description of the error, assuming that this message is not localized and is therefore EN-US. UI consumers can use the error.type value to provide a localized version of this error for presentation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Detail { get; set; }
#nullable restore
#else
        public string Detail { get; set; }
#endif
        /// <summary>The field which failed validation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Field { get; set; }
#nullable restore
#else
        public string Field { get; set; }
#endif
        /// <summary>A short title for the error</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The error code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ValidationError"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ValidationError CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidationError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"detail", n => { Detail = n.GetStringValue(); } },
                {"field", n => { Field = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteStringValue("field", Field);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
        }
    }
}
