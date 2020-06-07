
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class RSAKeyValueType
    {
        [XmlElement(DataType = "base64Binary")]
        public byte[] Modulus { get; set; }


		[XmlElement(DataType = "base64Binary")]
        public byte[] Exponent { get; set; }
	}
}