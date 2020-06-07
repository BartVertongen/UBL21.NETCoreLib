
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class ManifestType
    {
        [XmlElement("Reference")]
        public ReferenceType[] Reference { get; set; }

		[XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
	}
}