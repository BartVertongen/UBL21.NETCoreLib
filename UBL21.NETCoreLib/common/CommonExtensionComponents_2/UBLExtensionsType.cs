
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.CommonExtensionComponents_2
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRoot("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public class UBLExtensionsType
    {
        [XmlElement("UBLExtension")]
        public UBLExtensionType[] UBLExtension { get; set; }
    }
}