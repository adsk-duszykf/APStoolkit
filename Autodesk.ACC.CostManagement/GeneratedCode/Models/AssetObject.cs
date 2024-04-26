// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class AssetObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Id of the request to duplicate project assets.</summary>
        public Guid? AssetStatusUid { get; set; }
        /// <summary>true if the asset should be upserted, false if the asset should be deleted.</summary>
        public bool? ShouldCopyIntoProject { get; set; }
        /// <summary>Id of the source asset to copy from.</summary>
        public Guid? SourceObjectUid { get; set; }
        /// <summary>Id of the source project to copy the asset from.</summary>
        public Guid? SourceProjectUid { get; set; }
        /// <summary>A generic property bag for additional properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? SubscriptionContext { get; set; }
#nullable restore
#else
        public UntypedNode SubscriptionContext { get; set; }
#endif
        /// <summary>Id of the target asset to copy to.</summary>
        public Guid? TargetObjectUid { get; set; }
        /// <summary>Id of the target project to copy the asset to.</summary>
        public Guid? TargetProjectUid { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AssetObject"/> and sets the default values.
        /// </summary>
        public AssetObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AssetObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssetObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssetObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"asset_status_uid", n => { AssetStatusUid = n.GetGuidValue(); } },
                {"should_copy_into_project", n => { ShouldCopyIntoProject = n.GetBoolValue(); } },
                {"source_object_uid", n => { SourceObjectUid = n.GetGuidValue(); } },
                {"source_project_uid", n => { SourceProjectUid = n.GetGuidValue(); } },
                {"subscription_context", n => { SubscriptionContext = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                {"target_object_uid", n => { TargetObjectUid = n.GetGuidValue(); } },
                {"target_project_uid", n => { TargetProjectUid = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("asset_status_uid", AssetStatusUid);
            writer.WriteBoolValue("should_copy_into_project", ShouldCopyIntoProject);
            writer.WriteGuidValue("source_object_uid", SourceObjectUid);
            writer.WriteGuidValue("source_project_uid", SourceProjectUid);
            writer.WriteObjectValue<UntypedNode>("subscription_context", SubscriptionContext);
            writer.WriteGuidValue("target_object_uid", TargetObjectUid);
            writer.WriteGuidValue("target_project_uid", TargetProjectUid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
