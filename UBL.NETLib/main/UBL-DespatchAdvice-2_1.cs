
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
	[System.Xml.Serialization.XmlRootAttribute("DespatchAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", IsNullable = false)]
	public partial class DespatchAdviceType
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

		public DocumentStatusCodeType documentStatusCode { get; set; }

		public DespatchAdviceTypeCodeType despatchAdviceTypeCode { get; set; }

		public NoteType[] note { get; set; }

		public LineCountNumericType lineCountNumeric { get; set; }

		public OrderReferenceType[] orderReference { get; set; }

		public DocumentReferenceType[] additionalDocumentReference { get; set; }

		public SignatureType[] signature { get; set; }

		public SupplierPartyType despatchSupplierParty { get; set; }

		public CustomerPartyType deliveryCustomerParty { get; set; }

		public CustomerPartyType buyerCustomerParty { get; set; }

		public SupplierPartyType sellerSupplierParty { get; set; }

		public CustomerPartyType originatorCustomerParty { get; set; }

		public ShipmentType shipment { get; set; }

		public DespatchLineType[] despatchLine { get; set; }
	}
}