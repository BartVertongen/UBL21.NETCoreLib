
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;

namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")]
	[XmlRoot("DebitNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2", IsNullable = false)]
	public class DebitNoteType
	{

		public UBLExtensionType[] UBLExtensions { get; set; }

		public UBLVersionIDType UBLVersionID { get; set; }

		public CustomizationIDType CustomizationID { get; set; }

		public ProfileIDType ProfileID { get; set; }

		public ProfileExecutionIDType ProfileExecutionID { get; set; }

		public IDType Id { get; set; }

		public CopyIndicatorType CopyIndicator { get; set; }

		public UUIDType UUID { get; set; }

		public IssueDateType IssueDate { get; set; }

		public IssueTimeType IssueTime { get; set; }

		public NoteType[] Note { get; set; }

		public TaxPointDateType TaxPointDate { get; set; }

		public DocumentCurrencyCodeType DocumentCurrencyCode { get; set; }

		public TaxCurrencyCodeType TaxCurrencyCode { get; set; }

		public PricingCurrencyCodeType PricingCurrencyCode { get; set; }

		public PaymentCurrencyCodeType PaymentCurrencyCode { get; set; }

		public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode { get; set; }

		public AccountingCostCodeType AccountingCostCode { get; set; }

		public AccountingCostType AccountingCost { get; set; }

		public LineCountNumericType LineCountNumeric { get; set; }

		public PeriodType[] InvoicePeriod { get; set; }

		public ResponseType[] DiscrepancyResponse { get; set; }

		public OrderReferenceType OrderReference { get; set; }

		public BillingReferenceType[] BillingReference { get; set; }

		public DocumentReferenceType[] DespatchDocumentReference { get; set; }

		public DocumentReferenceType[] ReceiptDocumentReference { get; set; }

		public DocumentReferenceType[] StatementDocumentReference { get; set; }

		public DocumentReferenceType[] ContractDocumentReference { get; set; }

		public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

		public SignatureType[] Signature { get; set; }

		public SupplierPartyType AccountingSupplierParty { get; set; }

		public CustomerPartyType AccountingCustomerParty { get; set; }

		public PartyType PayeeParty { get; set; }

		public CustomerPartyType BuyerCustomerParty { get; set; }

		public SupplierPartyType SellerSupplierParty { get; set; }

		public PartyType TaxRepresentativeParty { get; set; }

		public PaymentType[] PrepaidPayment { get; set; }

		public AllowanceChargeType[] AllowanceCharge { get; set; }

		public DeliveryType[] Delivery { get; set; }

		public DeliveryTermsType[] DeliveryTerms { get; set; }

		public PaymentMeansType[] PaymentMeans { get; set; }

		public PaymentTermsType[] PaymentTerms { get; set; }

		public ExchangeRateType TaxExchangeRate { get; set; }

		public ExchangeRateType PricingExchangeRate { get; set; }

		public ExchangeRateType PaymentExchangeRate { get; set; }

		public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }

		public TaxTotalType[] TaxTotal { get; set; }

		public MonetaryTotalType RequestedMonetaryTotal { get; set; }

		public DebitNoteLineType[] DebitNoteLine { get; set; }

	}
}
