// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.FileManagement.Models {
    public class CustomAttributesValues_results : IParsable 
    {
        /// <summary>The approvalStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomAttributesValues_results_approvalStatus? ApprovalStatus { get; set; }
#nullable restore
#else
        public CustomAttributesValues_results_approvalStatus ApprovalStatus { get; set; }
#endif
        /// <summary>The createTime property</summary>
        public DateTimeOffset? CreateTime { get; set; }
        /// <summary>The createUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateUserId { get; set; }
#nullable restore
#else
        public string CreateUserId { get; set; }
#endif
        /// <summary>The createUserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateUserName { get; set; }
#nullable restore
#else
        public string CreateUserName { get; set; }
#endif
        /// <summary>The customAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomAttributesValues_results_customAttributes>? CustomAttributes { get; set; }
#nullable restore
#else
        public List<CustomAttributesValues_results_customAttributes> CustomAttributes { get; set; }
#endif
        /// <summary>The entityType property</summary>
        public CustomAttributesValues_results_entityType? EntityType { get; set; }
        /// <summary>The itemUrn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemUrn { get; set; }
#nullable restore
#else
        public string ItemUrn { get; set; }
#endif
        /// <summary>The lastModifiedTime property</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The lastModifiedUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUserId { get; set; }
#nullable restore
#else
        public string LastModifiedUserId { get; set; }
#endif
        /// <summary>The lastModifiedUserName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUserName { get; set; }
#nullable restore
#else
        public string LastModifiedUserName { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number { get; set; }
#nullable restore
#else
        public string Number { get; set; }
#endif
        /// <summary>The processState property</summary>
        public CustomAttributesValues_results_processState? ProcessState { get; set; }
        /// <summary>The revisionNumber property</summary>
        public int? RevisionNumber { get; set; }
        /// <summary>The storageSize property</summary>
        public int? StorageSize { get; set; }
        /// <summary>The storageUrn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageUrn { get; set; }
#nullable restore
#else
        public string StorageUrn { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The urn property</summary>
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
        /// <returns>A <see cref="CustomAttributesValues_results"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomAttributesValues_results CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomAttributesValues_results();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"approvalStatus", n => { ApprovalStatus = n.GetObjectValue<CustomAttributesValues_results_approvalStatus>(CustomAttributesValues_results_approvalStatus.CreateFromDiscriminatorValue); } },
                {"createTime", n => { CreateTime = n.GetDateTimeOffsetValue(); } },
                {"createUserId", n => { CreateUserId = n.GetStringValue(); } },
                {"createUserName", n => { CreateUserName = n.GetStringValue(); } },
                {"customAttributes", n => { CustomAttributes = n.GetCollectionOfObjectValues<CustomAttributesValues_results_customAttributes>(CustomAttributesValues_results_customAttributes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"entityType", n => { EntityType = n.GetEnumValue<CustomAttributesValues_results_entityType>(); } },
                {"itemUrn", n => { ItemUrn = n.GetStringValue(); } },
                {"lastModifiedTime", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedUserId", n => { LastModifiedUserId = n.GetStringValue(); } },
                {"lastModifiedUserName", n => { LastModifiedUserName = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"processState", n => { ProcessState = n.GetEnumValue<CustomAttributesValues_results_processState>(); } },
                {"revisionNumber", n => { RevisionNumber = n.GetIntValue(); } },
                {"storageSize", n => { StorageSize = n.GetIntValue(); } },
                {"storageUrn", n => { StorageUrn = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteObjectValue<CustomAttributesValues_results_approvalStatus>("approvalStatus", ApprovalStatus);
            writer.WriteDateTimeOffsetValue("createTime", CreateTime);
            writer.WriteStringValue("createUserId", CreateUserId);
            writer.WriteStringValue("createUserName", CreateUserName);
            writer.WriteCollectionOfObjectValues<CustomAttributesValues_results_customAttributes>("customAttributes", CustomAttributes);
            writer.WriteEnumValue<CustomAttributesValues_results_entityType>("entityType", EntityType);
            writer.WriteStringValue("itemUrn", ItemUrn);
            writer.WriteDateTimeOffsetValue("lastModifiedTime", LastModifiedTime);
            writer.WriteStringValue("lastModifiedUserId", LastModifiedUserId);
            writer.WriteStringValue("lastModifiedUserName", LastModifiedUserName);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("number", Number);
            writer.WriteEnumValue<CustomAttributesValues_results_processState>("processState", ProcessState);
            writer.WriteIntValue("revisionNumber", RevisionNumber);
            writer.WriteIntValue("storageSize", StorageSize);
            writer.WriteStringValue("storageUrn", StorageUrn);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
