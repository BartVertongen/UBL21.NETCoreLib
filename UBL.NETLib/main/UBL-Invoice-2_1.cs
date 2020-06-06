
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
	[XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
	public partial class InvoiceType
	{
		public UBLExtensionType[] uBLExtensions { get; set;}

		public UBLVersionIDType uBLVersionID { get; set;}

		public CustomizationIDType customizationID { get; set;}

		public ProfileIDType profileID { get; set;}

		public ProfileExecutionIDType profileExecutionID { get; set;}

		public IDType id { get; set;}

		public CopyIndicatorType copyIndicator { get; set;}

		public UUIDType uUID { get; set;}

		public IssueDateType issueDate { get; set;}

		public IssueTimeType issueTime { get; set;}

		public DueDateType dueDate { get; set;}

		public InvoiceTypeCodeType invoiceTypeCode { get; set;}

		public NoteType[] note { get; set;}

		public TaxPointDateType taxPointDate { get; set;}

		public DocumentCurrencyCodeType documentCurrencyCode { get; set;}

		public TaxCurrencyCodeType taxCurrencyCode { get; set;}

		public PricingCurrencyCodeType pricingCurrencyCode { get; set;}

		public PaymentCurrencyCodeType paymentCurrencyCode { get; set;}

		public PaymentAlternativeCurrencyCodeType paymentAlternativeCurrencyCode { get; set;}

		public AccountingCostCodeType accountingCostCode { get; set;}

		public AccountingCostType accountingCost { get; set;}

		public LineCountNumericType lineCountNumeric { get; set;}

		public BuyerReferenceType buyerReference { get; set;}

		public PeriodType[] invoicePeriod { get; set;}

		public OrderReferenceType orderReference { get; set;}

		public BillingReferenceType[] billingReference { get; set;}

		public DocumentReferenceType[] despatchDocumentReference { get; set;}

		public DocumentReferenceType[] receiptDocumentReference { get; set;}

		public DocumentReferenceType[] statementDocumentReference { get; set;}

		public DocumentReferenceType[] originatorDocumentReference { get; set;}

		public DocumentReferenceType[] contractDocumentReference { get; set;}

		public DocumentReferenceType[] additionalDocumentReference { get; set;}

		public ProjectReferenceType[] projectReference { get; set;}

		public SignatureType[] signature { get; set;}

		public SupplierPartyType accountingSupplierParty { get; set;}

		public CustomerPartyType accountingCustomerParty { get; set;}

		public PartyType payeeParty { get; set;}

		public CustomerPartyType buyerCustomerParty { get; set;}

		public SupplierPartyType sellerSupplierParty { get; set;}

		public PartyType taxRepresentativeParty { get; set;}

		public DeliveryType[] delivery { get; set;}

		public DeliveryTermsType deliveryTerms { get; set;}

		public PaymentMeansType[] paymentMeans { get; set;}

		public PaymentTermsType[] paymentTerms { get; set;}

		public PaymentType[] prepaidPayment { get; set;}

		public AllowanceChargeType[] allowanceCharge { get; set;}

		public ExchangeRateType taxExchangeRate { get; set;}

		public ExchangeRateType pricingExchangeRate { get; set;}

		public ExchangeRateType paymentExchangeRate { get; set;}

		public ExchangeRateType paymentAlternativeExchangeRate { get; set;}

		public TaxTotalType[] taxTotal { get; set;}

		public TaxTotalType[] withholdingTaxTotal { get; set;}

		public MonetaryTotalType legalMonetaryTotal { get; set;}

		public InvoiceLineType[] invoiceLine { get; set;}
	}
}