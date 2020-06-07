
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;


namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName = "BinaryObjectType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class BinaryObjectType1 : BinaryObjectType
    {
    }
}