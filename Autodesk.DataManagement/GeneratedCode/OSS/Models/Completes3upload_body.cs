// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.OSS.Models {
    public class Completes3upload_body : IParsable 
    {
        /// <summary>An array of eTags. For a single-part upload, this array contains the expected eTag of the entire object. For a multipart upload, this array contains the expected eTag of each part of the upload; the index of an eTag in the array corresponds to its part number in the upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ETags { get; set; }
#nullable restore
#else
        public List<string> ETags { get; set; }
#endif
        /// <summary>The expected size of the uploaded object. If provided, OSS will check this against the blob in S3 and return an error if the size does not match.</summary>
        public int? Size { get; set; }
        /// <summary>The identifier of the upload session, which was provided by OSS in the response to the request for the signed URL/s with which to upload the object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploadKey { get; set; }
#nullable restore
#else
        public string UploadKey { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Completes3upload_body"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Completes3upload_body CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Completes3upload_body();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"eTags", n => { ETags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"uploadKey", n => { UploadKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("eTags", ETags);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("uploadKey", UploadKey);
        }
    }
}
