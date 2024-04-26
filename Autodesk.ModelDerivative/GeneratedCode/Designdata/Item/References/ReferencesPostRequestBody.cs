// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ModelDerivative.Designdata.Item.References {
    public class ReferencesPostRequestBody : IParsable 
    {
        /// <summary>The root design filename. By default, it is set to “” and the file will be download with its urn.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filename { get; set; }
#nullable restore
#else
        public string Filename { get; set; }
#endif
        /// <summary>Group of references.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ReferencesPostRequestBody_references>? References { get; set; }
#nullable restore
#else
        public List<ReferencesPostRequestBody_references> References { get; set; }
#endif
        /// <summary>Region in which to store references. Possible values: US, EMEA. By default, it is set to US.</summary>
        public ReferencesPostRequestBody_region? Region { get; set; }
        /// <summary>The root design urn. Mandatory if the base64 encoded urn in the request URL is a logical urn.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ReferencesPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReferencesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferencesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"filename", n => { Filename = n.GetStringValue(); } },
                {"references", n => { References = n.GetCollectionOfObjectValues<ReferencesPostRequestBody_references>(ReferencesPostRequestBody_references.CreateFromDiscriminatorValue)?.ToList(); } },
                {"region", n => { Region = n.GetEnumValue<ReferencesPostRequestBody_region>(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("filename", Filename);
            writer.WriteCollectionOfObjectValues<ReferencesPostRequestBody_references>("references", References);
            writer.WriteEnumValue<ReferencesPostRequestBody_region>("region", Region);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
