
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;


namespace VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2
{
    [XmlInclude(typeof(VideoType))]
    [XmlInclude(typeof(SoundType))]
    [XmlInclude(typeof(PictureType))]
    [XmlInclude(typeof(GraphicType))]
    [XmlInclude(typeof(BinaryObjectType1))]
    [XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType
    {
        [XmlAttribute()]
        public string format { get; set; }


        [XmlAttribute(DataType = "normalizedString")]
        public string mimeCode { get; set; }


        [XmlAttribute(DataType = "normalizedString")]
        public string encodingCode { get; set; }


        [XmlAttribute(DataType = "normalizedString")]
        public string characterSetCode { get; set; }


        [XmlAttribute(DataType = "anyURI")]
        public string uri { get; set; }


        [XmlAttribute()]
        public string filename { get; set; }


        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}