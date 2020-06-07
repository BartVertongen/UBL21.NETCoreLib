using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace VertSoft.ubl21.common.xmlenc
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2001/04/xmlenc#")]
    [XmlRoot(Namespace = "http://www.w3.org/2001/04/xmlenc#", IsNullable = false)]
    public class ReferenceList
    {

        private ReferenceType[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        [XmlElement("DataReference", typeof(ReferenceType))]
        [XmlElement("KeyReference", typeof(ReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public ReferenceType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }
}
