// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.DefaultValues {
    [Obsolete("This class is obsolete. Use DefaultValuesGetResponse instead.")]
    public class DefaultValuesResponse : DefaultValuesGetResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DefaultValuesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DefaultValuesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultValuesResponse();
        }
    }
}
