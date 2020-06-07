
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
	[XmlRoot("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2", IsNullable = false)]
	public class CallForTendersType
	{
		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public CopyIndicatorType copyIndicator { get; set; }

		public UUIDType uUID { get; set; }

		public ContractFolderIDType contractFolderID { get; set; }

		public ApprovalDateType approvalDate { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public NoteType[] note { get; set; }

		public VersionIDType versionID { get; set; }

		public PreviousVersionIDType previousVersionID { get; set; }

		public DocumentReferenceType legalDocumentReference { get; set; }

		public DocumentReferenceType technicalDocumentReference { get; set; }

		public DocumentReferenceType[] additionalDocumentReference { get; set; }

		public SignatureType[] signature { get; set; }

		public ContractingPartyType contractingParty { get; set; }

		public CustomerPartyType[] originatorCustomerParty { get; set; }

		public PartyType receiverParty { get; set; }

		public TenderingTermsType tenderingTerms { get; set; }

		public TenderingProcessType tenderingProcess { get; set; }

		public ProcurementProjectType procurementProject { get; set; }

		public ProcurementProjectLotType[] procurementProjectLot { get; set; }

	}
}
