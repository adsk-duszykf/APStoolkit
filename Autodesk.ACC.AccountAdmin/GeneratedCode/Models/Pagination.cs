// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.AccountAdmin.Models {
    /// <summary>
    /// The information on the current page of a response.
    /// </summary>
    public class Pagination : IParsable {
        /// <summary>The number of results to include in the response.</summary>
        public int? Limit { get; private set; }
        /// <summary>The record number to start with.</summary>
        public int? Offset { get; private set; }
        /// <summary>The total number of records.</summary>
        public int? TotalResults { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pagination CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pagination();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
                {"totalResults", n => { TotalResults = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}
