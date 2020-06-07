
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;

namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [XmlInclude(typeof(TargetCurrencyBaseRateType))]
    [XmlInclude(typeof(SourceCurrencyBaseRateType))]
    [XmlInclude(typeof(RateType1))]
    [XmlInclude(typeof(OrderableUnitFactorRateType))]
    [XmlInclude(typeof(CalculationRateType))]
    [XmlInclude(typeof(AmountRateType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class RateType : NumericType
    {
    }
}