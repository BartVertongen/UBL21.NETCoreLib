
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")]
    [XmlRoot("ApplicationResponse", Namespace="urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2", IsNullable=false)]
    public class ApplicationResponseType
    {   
        public UBLExtensionType[] uBLExtensions { get; set; }
    
        public UBLVersionIDType uBLVersionID { get; set; }
    
        public CustomizationIDType customizationID { get; set; }
    
        public ProfileIDType profileID { get; set; }
    
        public ProfileExecutionIDType profileExecutionID { get; set; }
    
        public IDType id { get; set; }
    
        public UUIDType uUID { get; set; }
    
        public IssueDateType issueDate { get; set; }
    
        public IssueTimeType issueTime { get; set; }
    
        public ResponseDateType responseDate { get; set; }
    
        public ResponseTimeType responseTime { get; set; }
    
        public NoteType[] note { get; set; }
    
        public VersionIDType versionID { get; set; }
    
        public SignatureType[] signature { get; set; }
    
        public PartyType senderParty { get; set; }
    
        public PartyType receiverParty { get; set; }
    
        public DocumentResponseType[] documentResponse { get; set; }
    
    }
}