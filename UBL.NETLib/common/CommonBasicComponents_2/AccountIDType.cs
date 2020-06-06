
using System.Xml.Serialization;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.common.CommonBasicComponents_2
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [XmlRootAttribute("AccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public class AccountIDType : IdentifierType1
    {
    }
}