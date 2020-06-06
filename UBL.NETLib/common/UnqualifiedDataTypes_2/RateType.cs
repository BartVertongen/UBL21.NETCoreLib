
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;

namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderableUnitFactorRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationRateType))]
    [XmlIncludeAttribute(typeof(AmountRateType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class RateType : NumericType
    {
    }
}