// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.Models {
    public class SegmentValueListResponseWithOffset : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Pagination information when data must be returned page by page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Autodesk.ACC.CostManagement.Models.Pagination? Pagination { get; set; }
#nullable restore
#else
        public Autodesk.ACC.CostManagement.Models.Pagination Pagination { get; set; }
#endif
        /// <summary>The detailed segment definition values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SegmentValue>? Results { get; set; }
#nullable restore
#else
        public List<SegmentValue> Results { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SegmentValueListResponseWithOffset"/> and sets the default values.
        /// </summary>
        public SegmentValueListResponseWithOffset()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SegmentValueListResponseWithOffset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SegmentValueListResponseWithOffset CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SegmentValueListResponseWithOffset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"pagination", n => { Pagination = n.GetObjectValue<Autodesk.ACC.CostManagement.Models.Pagination>(Autodesk.ACC.CostManagement.Models.Pagination.CreateFromDiscriminatorValue); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<SegmentValue>(SegmentValue.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Autodesk.ACC.CostManagement.Models.Pagination>("pagination", Pagination);
            writer.WriteCollectionOfObjectValues<SegmentValue>("results", Results);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
