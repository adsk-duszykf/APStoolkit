// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Autodesk.ModelDerivative.Models {
    /// <summary>Specifies how storeys are translated. Available options are:- hide - (default) storeys are extracted but not visible by default.- show - storeys are extracted and are visible by default.- skip - storeys are not translated.Note These options are applicable only when conversionMethod is set to modern or v3.</summary>
    public enum JobPayloadFormat_advanced_buildingStoreys
    {
        [EnumMember(Value = "hide")]
        Hide,
        [EnumMember(Value = "show")]
        Show,
        [EnumMember(Value = "skip")]
        Skip,
    }
}
