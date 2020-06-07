
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmlenc
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [XmlRoot("CipherData", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public class CipherDataType
    {
        [XmlElement("CipherReference", typeof(CipherReferenceType))]
        [XmlElement("CipherValue", typeof(byte[]), DataType = "base64Binary")]
        public object Item { get; set; }
	}
}