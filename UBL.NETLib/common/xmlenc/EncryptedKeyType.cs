using System;
using System.Collections.Generic;
using System.Text;

namespace VertSoft.ubl21.common.xmlenc
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [System.Xml.Serialization.XmlRootAttribute("EncryptedKey", Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public partial class EncryptedKeyType : EncryptedType
    {

        private ReferenceList referenceListField;

        private string carriedKeyNameField;

        private string recipientField;

        /// <remarks/>
        public ReferenceList ReferenceList
        {
            get
            {
                return this.referenceListField;
            }
            set
            {
                this.referenceListField = value;
            }
        }

        /// <remarks/>
        public string CarriedKeyName
        {
            get
            {
                return this.carriedKeyNameField;
            }
            set
            {
                this.carriedKeyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Recipient
        {
            get
            {
                return this.recipientField;
            }
            set
            {
                this.recipientField = value;
            }
        }
    }
}
