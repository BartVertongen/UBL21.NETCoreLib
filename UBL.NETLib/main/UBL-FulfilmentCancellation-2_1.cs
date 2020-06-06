
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;

namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FulfilmentCancellation-2")]
	[XmlRoot("FulfilmentCancellation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FulfilmentCancellation-2", IsNullable = false)]
	public partial class FulfilmentCancellationType
	{
		public UBLExtensionType[] UBLExtensions { get; set; }

		public UBLVersionIDType UBLVersionID { get; set; }

		public CustomizationIDType CustomizationID { get; set; }

		public ProfileIDType ProfileID { get; set; }

		public ProfileExecutionIDType ProfileExecutionID { get; set; }

		public IDType ID { get; set; }

		public CopyIndicatorType CopyIndicator { get; set; }

		public UUIDType UUID { get; set; }

		public IssueDateType IssueDate { get; set; }

		public IssueTimeType IssueTime { get; set; }

		public NoteType[] Note { get; set; }

		public CancellationNoteType[] CancellationNote { get; set; }

		public DocumentReferenceType[] DespatchDocumentReference { get; set; }

		public DocumentReferenceType[] ReceiptDocumentReference { get; set; }

		public OrderReferenceType[] OrderReference { get; set; }

		public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

		public ContractType[] Contract { get; set; }

		public SignatureType[] Signature { get; set; }

		public CustomerPartyType BuyerCustomerParty { get; set; }

		public SupplierPartyType SellerSupplierParty { get; set; }

		public CustomerPartyType DeliveryCustomerParty { get; set; }

		public SupplierPartyType DespatchSupplierParty { get; set; }

		public CustomerPartyType OriginatorCustomerParty { get; set; }
	}
}