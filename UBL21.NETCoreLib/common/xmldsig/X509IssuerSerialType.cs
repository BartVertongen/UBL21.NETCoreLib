
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509IssuerSerialType
    {
        public string X509IssuerName { get; set; }

		[XmlElement(DataType = "integer")]
        public string X509SerialNumber { get; set; }
	}
}