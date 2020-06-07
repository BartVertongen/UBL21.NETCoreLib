
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;


namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [XmlInclude(typeof(TierRatePercentType))]
    [XmlInclude(typeof(TargetServicePercentType))]
    [XmlInclude(typeof(SettlementDiscountPercentType))]
    [XmlInclude(typeof(ReliabilityPercentType))]
    [XmlInclude(typeof(ProgressPercentType))]
    [XmlInclude(typeof(PercentType1))]
    [XmlInclude(typeof(PenaltySurchargePercentType))]
    [XmlInclude(typeof(PaymentPercentType))]
    [XmlInclude(typeof(ParticipationPercentType))]
    [XmlInclude(typeof(PartecipationPercentType))]
    [XmlInclude(typeof(MinimumPercentType))]
    [XmlInclude(typeof(MaximumPercentType))]
    [XmlInclude(typeof(HumidityPercentType))]
    [XmlInclude(typeof(AirFlowPercentType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class PercentType : NumericType
    {
    }
}