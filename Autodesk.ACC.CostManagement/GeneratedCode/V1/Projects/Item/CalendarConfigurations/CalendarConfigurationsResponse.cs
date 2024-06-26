// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Autodesk.ACC.CostManagement.V1.Projects.Item.CalendarConfigurations {
    [Obsolete("This class is obsolete. Use CalendarConfigurationsGetResponse instead.")]
    public class CalendarConfigurationsResponse : CalendarConfigurationsGetResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CalendarConfigurationsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarConfigurationsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarConfigurationsResponse();
        }
    }
}
