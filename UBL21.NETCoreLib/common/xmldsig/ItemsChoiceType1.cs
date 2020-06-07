
using System.Xml.Serialization;

namespace VertSoft.ubl21.common.xmldsig
{
    [System.Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        [XmlEnum("##any:")]
        Item,
        PGPKeyID,
        PGPKeyPacket,
    }
}