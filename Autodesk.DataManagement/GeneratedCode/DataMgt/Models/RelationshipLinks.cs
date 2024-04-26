// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    /// <summary>
    /// Successful retrieval of the links collection associated with a specific resource.
    /// </summary>
    public class RelationshipLinks : IParsable 
    {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RelationshipLinks_data>? Data { get; set; }
#nullable restore
#else
        public List<RelationshipLinks_data> Data { get; set; }
#endif
        /// <summary>The jsonapi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelationshipLinks_jsonapi? Jsonapi { get; set; }
#nullable restore
#else
        public RelationshipLinks_jsonapi Jsonapi { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RelationshipLinks_links? Links { get; set; }
#nullable restore
#else
        public RelationshipLinks_links Links { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RelationshipLinks"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RelationshipLinks CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelationshipLinks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"data", n => { Data = n.GetCollectionOfObjectValues<RelationshipLinks_data>(RelationshipLinks_data.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jsonapi", n => { Jsonapi = n.GetObjectValue<RelationshipLinks_jsonapi>(RelationshipLinks_jsonapi.CreateFromDiscriminatorValue); } },
                {"links", n => { Links = n.GetObjectValue<RelationshipLinks_links>(RelationshipLinks_links.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<RelationshipLinks_data>("data", Data);
            writer.WriteObjectValue<RelationshipLinks_jsonapi>("jsonapi", Jsonapi);
            writer.WriteObjectValue<RelationshipLinks_links>("links", Links);
        }
    }
}
