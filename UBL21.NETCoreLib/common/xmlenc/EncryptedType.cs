
using System.Xml.Serialization;
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common.xmlenc
{
    [XmlInclude(typeof(EncryptedKeyType))]
    [XmlInclude(typeof(EncryptedDataType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    public abstract partial class EncryptedType
    {
        public EncryptionMethodType EncryptionMethod { get; set; }

		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public KeyInfoType KeyInfo { get; set; }

		public CipherDataType CipherData { get; set; }

		public EncryptionPropertiesType EncryptionProperties { get; set; }

		[XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

		[XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }

		[XmlAttribute()]
        public string MimeType { get; set; }

		[XmlAttribute(DataType = "anyURI")]
        public string Encoding { get; set; }
	}
}
