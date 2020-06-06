
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
    [XmlIncludeAttribute(typeof(BinaryObjectType1))]
    [XmlIncludeAttribute(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType
    {

        private string formatField;

        private string mimeCodeField;

        private string encodingCodeField;

        private string characterSetCodeField;

        private string uriField;

        private string filenameField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }


        [XmlAttribute(DataType = "normalizedString")]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }


        [XmlAttribute(DataType = "normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }


        [XmlAttributeAttribute(DataType = "normalizedString")]
        public string characterSetCode
        {
            get
            {
                return this.characterSetCodeField;
            }
            set
            {
                this.characterSetCodeField = value;
            }
        }


        [XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }


        [XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }


        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}