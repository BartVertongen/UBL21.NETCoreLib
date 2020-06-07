
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class ReferenceType
    {
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }

		public DigestMethodType DigestMethod { get; set; }

		[XmlElement(DataType = "base64Binary")]
        public byte[] DigestValue { get; set; }

		[XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

		[XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }

		[XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }
	}
}