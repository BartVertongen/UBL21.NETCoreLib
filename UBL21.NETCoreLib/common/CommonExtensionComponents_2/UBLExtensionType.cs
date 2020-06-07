
using System.Xml;
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;


namespace VertSoft.ubl21.common.CommonExtensionComponents_2
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRoot("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public class UBLExtensionType
    {
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID { get; set; }


        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name { get; set; }

        public ExtensionAgencyIDType ExtensionAgencyID { get; set; }

        public ExtensionAgencyNameType ExtensionAgencyName { get; set; }

        public ExtensionVersionIDType ExtensionVersionID { get; set; }

        public ExtensionAgencyURIType ExtensionAgencyURI { get; set; }

        public ExtensionURIType ExtensionURI { get; set; }

        public ExtensionReasonCodeType ExtensionReasonCode { get; set; }

        public ExtensionReasonType ExtensionReason { get; set; }

        public XmlElement ExtensionContent { get; set; }
    }
}