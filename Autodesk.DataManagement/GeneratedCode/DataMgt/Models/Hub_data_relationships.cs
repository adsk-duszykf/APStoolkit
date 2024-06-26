// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.DataManagement.Models {
    public class Hub_data_relationships : IParsable 
    {
        /// <summary>The pimCollection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Hub_data_relationships_pimCollection? PimCollection { get; set; }
#nullable restore
#else
        public Hub_data_relationships_pimCollection PimCollection { get; set; }
#endif
        /// <summary>The projects property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Hub_data_relationships_projects? Projects { get; set; }
#nullable restore
#else
        public Hub_data_relationships_projects Projects { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Hub_data_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Hub_data_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Hub_data_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"pimCollection", n => { PimCollection = n.GetObjectValue<Hub_data_relationships_pimCollection>(Hub_data_relationships_pimCollection.CreateFromDiscriminatorValue); } },
                {"projects", n => { Projects = n.GetObjectValue<Hub_data_relationships_projects>(Hub_data_relationships_projects.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Hub_data_relationships_pimCollection>("pimCollection", PimCollection);
            writer.WriteObjectValue<Hub_data_relationships_projects>("projects", Projects);
        }
    }
}
