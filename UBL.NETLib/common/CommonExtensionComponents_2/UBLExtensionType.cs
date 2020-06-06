
using System.Xml;
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;


namespace VertSoft.ubl21.common.CommonExtensionComponents_2
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UBLExtensionType
    {

        private IDType idField;

        private NameType nameField;

        private ExtensionAgencyIDType extensionAgencyIDField;

        private ExtensionAgencyNameType extensionAgencyNameField;

        private ExtensionVersionIDType extensionVersionIDField;

        private ExtensionAgencyURIType extensionAgencyURIField;

        private ExtensionURIType extensionURIField;

        private ExtensionReasonCodeType extensionReasonCodeField;

        private ExtensionReasonType extensionReasonField;

        private XmlElement extensionContentField;


        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }


        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public ExtensionAgencyIDType ExtensionAgencyID
        {
            get
            {
                return this.extensionAgencyIDField;
            }
            set
            {
                this.extensionAgencyIDField = value;
            }
        }

        public ExtensionAgencyNameType ExtensionAgencyName
        {
            get
            {
                return this.extensionAgencyNameField;
            }
            set
            {
                this.extensionAgencyNameField = value;
            }
        }

        public ExtensionVersionIDType ExtensionVersionID
        {
            get
            {
                return this.extensionVersionIDField;
            }
            set
            {
                this.extensionVersionIDField = value;
            }
        }

        public ExtensionAgencyURIType ExtensionAgencyURI
        {
            get
            {
                return this.extensionAgencyURIField;
            }
            set
            {
                this.extensionAgencyURIField = value;
            }
        }

        /// <remarks/>
        public ExtensionURIType ExtensionURI
        {
            get
            {
                return this.extensionURIField;
            }
            set
            {
                this.extensionURIField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonCodeType ExtensionReasonCode
        {
            get
            {
                return this.extensionReasonCodeField;
            }
            set
            {
                this.extensionReasonCodeField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonType ExtensionReason
        {
            get
            {
                return this.extensionReasonField;
            }
            set
            {
                this.extensionReasonField = value;
            }
        }


        public XmlElement ExtensionContent
        {
            get
            {
                return this.extensionContentField;
            }
            set
            {
                this.extensionContentField = value;
            }
        }
    }
}