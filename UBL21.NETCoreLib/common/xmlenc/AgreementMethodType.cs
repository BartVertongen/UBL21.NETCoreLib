
using System.Xml.Serialization;
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common.xmlenc
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [XmlRoot("AgreementMethod", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public class AgreementMethodType
    {
        [XmlElement("KA-Nonce", DataType = "base64Binary")]
        public byte[] KANonce { get; set; }


		[XmlText()]
        [XmlAnyElement()]
        public System.Xml.XmlNode[] Any { get; set; }


		public KeyInfoType OriginatorKeyInfo { get; set; }


		public KeyInfoType RecipientKeyInfo { get; set; }


		[XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
	}
}
