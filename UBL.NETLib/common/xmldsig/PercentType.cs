
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;

namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TierRatePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetServicePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettlementDiscountPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReliabilityPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProgressPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PenaltySurchargePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParticipationPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartecipationPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HumidityPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirFlowPercentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class PercentType : NumericType
    {
    }
}