
using System.Xml.Serialization;


//Also in namespace VertSoft.ubl21.common.xmlenc
namespace VertSoft.ubl21.common.xmldsig
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class TransformsType
    {
        [XmlElement("Transform")]
        public TransformType[] Transform { get; set; }
	}
}