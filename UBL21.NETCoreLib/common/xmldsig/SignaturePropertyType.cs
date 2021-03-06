
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignaturePropertyType
    {
        [XmlAnyElement()]
        public System.Xml.XmlElement[] Items { get; set; }


		[XmlText()]
        public string[] Text { get; set; }


		[XmlAttribute(DataType = "anyURI")]
        public string Target { get; set; }


		[XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
	}
}