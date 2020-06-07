using System.Xml.Serialization;
using System.Xml;

namespace VertSoft.ubl21.common.xmldsig
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class DigestMethodType
    {
        [XmlText()]
        [XmlAnyElement()]
        public XmlNode[] Any { get; set; }


		[XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
	}
}