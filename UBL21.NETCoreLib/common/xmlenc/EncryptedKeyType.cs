
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmlenc
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [XmlRoot("EncryptedKey", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public class EncryptedKeyType : EncryptedType
    {
        public ReferenceList ReferenceList { get; set; }


		public string CarriedKeyName { get; set; }


		[XmlAttribute()]
        public string Recipient { get; set; }
	}
}
