// <auto-generated/>
using Autodesk.ACC.AccountAdmin.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.AccountAdmin.Projects.Item.Users {
    public class UsersGetResponse : IParsable {
        /// <summary>The information on the current page of a response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Autodesk.ACC.AccountAdmin.Models.Pagination? Pagination { get; set; }
#nullable restore
#else
        public Autodesk.ACC.AccountAdmin.Models.Pagination Pagination { get; set; }
#endif
        /// <summary>The requested page of project users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProjectUserResponse>? Results { get; set; }
#nullable restore
#else
        public List<ProjectUserResponse> Results { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UsersGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsersGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"pagination", n => { Pagination = n.GetObjectValue<Autodesk.ACC.AccountAdmin.Models.Pagination>(Autodesk.ACC.AccountAdmin.Models.Pagination.CreateFromDiscriminatorValue); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<ProjectUserResponse>(ProjectUserResponse.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Autodesk.ACC.AccountAdmin.Models.Pagination>("pagination", Pagination);
            writer.WriteCollectionOfObjectValues<ProjectUserResponse>("results", Results);
        }
    }
}
