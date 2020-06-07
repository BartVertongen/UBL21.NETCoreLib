
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignatureMethodType
    {
		[XmlText()]
        [XmlAnyElement()]
        public System.Xml.XmlNode[] Any { get; set; }


		[XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
	}
}