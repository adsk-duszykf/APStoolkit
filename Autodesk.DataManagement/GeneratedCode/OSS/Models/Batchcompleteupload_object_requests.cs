// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.OSS.Models {
    public class Batchcompleteupload_object_requests : IParsable 
    {
        /// <summary>The eTags of the parts uploaded to S3, exactly as returned by S3. The index of an eTag in the array corresponds to the number of the part in the entire object. If provided, OSS will fail the upload completion if any part does not match the data found in S3.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ETags { get; set; }
#nullable restore
#else
        public List<string> ETags { get; set; }
#endif
        /// <summary>The key/name of the object for which to complete an upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectKey { get; set; }
#nullable restore
#else
        public string ObjectKey { get; set; }
#endif
        /// <summary>The size of the object for which to complete an upload. If provided, OSS will fail the upload completion if the size does not match that of the data found in S3.</summary>
        public int? Size { get; set; }
        /// <summary>The key of the upload to complete.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploadKey { get; set; }
#nullable restore
#else
        public string UploadKey { get; set; }
#endif
        /// <summary>The Cache-Control value that OSS will store in the record for the uploaded object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XAdsMetaCacheControl { get; set; }
#nullable restore
#else
        public string XAdsMetaCacheControl { get; set; }
#endif
        /// <summary>The Content-Disposition value that OSS will store in the record for the uploaded object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XAdsMetaContentDisposition { get; set; }
#nullable restore
#else
        public string XAdsMetaContentDisposition { get; set; }
#endif
        /// <summary>The Content-Encoding value that OSS will store in the record for the uploaded object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XAdsMetaContentEncoding { get; set; }
#nullable restore
#else
        public string XAdsMetaContentEncoding { get; set; }
#endif
        /// <summary>The Content-Type value that OSS will store in the record for the uploaded object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XAdsMetaContentType { get; set; }
#nullable restore
#else
        public string XAdsMetaContentType { get; set; }
#endif
        /// <summary>This parameter allows setting any custom metadata to be stored with the object, which can be retrieved later on download or when getting the object details. It has the following restrictions: - It must have a JSON format. - The maximum length is 100 bytes</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? XAdsUserDefinedMetadata { get; set; }
#nullable restore
#else
        public string XAdsUserDefinedMetadata { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Batchcompleteupload_object_requests"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Batchcompleteupload_object_requests CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Batchcompleteupload_object_requests();
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
                {"objectKey", n => { ObjectKey = n.GetStringValue(); } },
                {"size", n => { Size = n.GetIntValue(); } },
                {"uploadKey", n => { UploadKey = n.GetStringValue(); } },
                {"x-ads-meta-Cache-Control", n => { XAdsMetaCacheControl = n.GetStringValue(); } },
                {"x-ads-meta-Content-Disposition", n => { XAdsMetaContentDisposition = n.GetStringValue(); } },
                {"x-ads-meta-Content-Encoding", n => { XAdsMetaContentEncoding = n.GetStringValue(); } },
                {"x-ads-meta-Content-Type", n => { XAdsMetaContentType = n.GetStringValue(); } },
                {"x-ads-user-defined-metadata", n => { XAdsUserDefinedMetadata = n.GetStringValue(); } },
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
            writer.WriteStringValue("objectKey", ObjectKey);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("uploadKey", UploadKey);
            writer.WriteStringValue("x-ads-meta-Cache-Control", XAdsMetaCacheControl);
            writer.WriteStringValue("x-ads-meta-Content-Disposition", XAdsMetaContentDisposition);
            writer.WriteStringValue("x-ads-meta-Content-Encoding", XAdsMetaContentEncoding);
            writer.WriteStringValue("x-ads-meta-Content-Type", XAdsMetaContentType);
            writer.WriteStringValue("x-ads-user-defined-metadata", XAdsUserDefinedMetadata);
        }
    }
}
