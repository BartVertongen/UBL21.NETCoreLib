
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ExceptionCriteria-2")]
	[XmlRootAttribute("ExceptionCriteria", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ExceptionCriteria-2", IsNullable = false)]
	public partial class ExceptionCriteriaType
	{

		private UBLExtensionType[] uBLExtensions { get; set; }

		private UBLVersionIDType uBLVersionID { get; set; }

		private CustomizationIDType customizationID { get; set; }

		private ProfileIDType profileID { get; set; }

		private ProfileExecutionIDType profileExecutionID { get; set; }

		private IDType id { get; set; }

		private CopyIndicatorType copyIndicator { get; set; }

		private UUIDType uUID { get; set; }

		private IssueDateType issueDate { get; set; }

		private IssueTimeType issueTime { get; set; }

		private NoteType[] note { get; set; }

		private VersionIDType versionID { get; set; }

		private PeriodType validityPeriod { get; set; }

		private DocumentReferenceType[] documentReference { get; set; }

		private SignatureType[] signature { get; set; }

		private PartyType senderParty { get; set; }

		private PartyType receiverParty { get; set; }

		private CustomerPartyType buyerCustomerParty { get; set; }

		private SupplierPartyType sellerSupplierParty { get; set; }

		private ExceptionCriteriaLineType[] exceptionCriteriaLine { get; set; }

	}
}
