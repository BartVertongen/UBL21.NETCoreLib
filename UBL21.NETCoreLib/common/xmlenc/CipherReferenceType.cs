
using System.Xml.Serialization;
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common.xmlenc
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [XmlRoot("CipherReference", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public class CipherReferenceType
    {
        [XmlElement("Transforms")]
        public TransformsType Item { get; set; }

		[XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }
	}
}