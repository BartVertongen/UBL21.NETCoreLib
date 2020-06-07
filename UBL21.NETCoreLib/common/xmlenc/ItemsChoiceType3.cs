
using System.Xml.Serialization;

namespace VertSoft.ubl21.common.xmlenc
{
    [System.Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2001/04/xmlenc#", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {
        DataReference,
        KeyReference,
    }
}
