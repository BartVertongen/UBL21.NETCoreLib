
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;

namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForecastRevision-2")]
	[XmlRootAttribute("ForecastRevision", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForecastRevision-2", IsNullable = false)]
	public partial class ForecastRevisionType
	{

		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public CopyIndicatorType copyIndicator { get; set; }

		public UUIDType uUID { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public NoteType[] note { get; set; }

		public SequenceNumberIDType sequenceNumberID { get; set; }

		public RevisionStatusCodeType revisionStatusCode { get; set; }

		public PurposeCodeType purposeCode { get; set; }

		public PeriodType forecastPeriod { get; set; }

		public DocumentReferenceType[] originalDocumentReference { get; set; }

		public SignatureType[] signature { get; set; }

		public PartyType senderParty { get; set; }

		public PartyType receiverParty { get; set; }

		public CustomerPartyType buyerCustomerParty { get; set; }

		public SupplierPartyType sellerSupplierParty { get; set; }

		public ForecastRevisionLineType[] forecastRevisionLine { get; set; }
	}
}
