
using System.Xml.Serialization;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;


namespace VertSoft.ubl21.common.CommonBasicComponents_2
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [XmlRoot("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class AcceptedVariantsDescriptionType : TextType1
    {
    }
}