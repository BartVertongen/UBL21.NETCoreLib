
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignatureType
    {
        public SignedInfoType SignedInfo { get; set; }


		public SignatureValueType SignatureValue { get; set; }


		public KeyInfoType KeyInfo { get; set; }


		[XmlElement("Object")]
        public ObjectType[] Object { get; set; }


		[XmlAttribute(DataType="ID")]
        public string Id { get; set; }
	}
}