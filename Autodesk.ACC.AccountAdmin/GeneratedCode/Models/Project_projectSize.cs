// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.AccountAdmin.Models {
    /// <summary>
    /// The size of this project.  When updating the project size both the `value` and `unit` are required.
    /// </summary>
    public class Project_projectSize : IParsable {
        /// <summary>The unit of measure of the project size for this project.  Allowed values are `sq. ft`, `sq. meters`, `sq. km`, `sq. miles`, `acres`, `ft`, `meters`, `km` and `miles`.  Defaults to `sq. ft`.</summary>
        public Project_projectSize_unit? Unit { get; set; }
        /// <summary>The size of the project based on the unit specified in the unit field.  Unit defaults to `sq. ft`.</summary>
        public float? Value { get; set; }
        /// <summary>
        /// Instantiates a new project_projectSize and sets the default values.
        /// </summary>
        public Project_projectSize() {
            Unit = Project_projectSize_unit.SqFt;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Project_projectSize CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Project_projectSize();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"unit", n => { Unit = n.GetEnumValue<Project_projectSize_unit>(); } },
                {"value", n => { Value = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Project_projectSize_unit>("unit", Unit);
            writer.WriteFloatValue("value", Value);
        }
    }
}
