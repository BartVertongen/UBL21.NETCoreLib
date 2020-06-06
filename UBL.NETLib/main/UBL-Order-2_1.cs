
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Order-2")]
	[System.Xml.Serialization.XmlRootAttribute("Order", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Order-2", IsNullable = false)]
	public partial class OrderType
	{
		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public SalesOrderIDType salesOrderID { get; set; }

		public CopyIndicatorType copyIndicator { get; set; }

		public UUIDType uUID { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public OrderTypeCodeType orderTypeCode { get; set; }

		public NoteType[] note { get; set; }

		public RequestedInvoiceCurrencyCodeType requestedInvoiceCurrencyCode { get; set; }

		public DocumentCurrencyCodeType documentCurrencyCode { get; set; }

		public PricingCurrencyCodeType pricingCurrencyCode { get; set; }

		public TaxCurrencyCodeType taxCurrencyCode { get; set; }

		public CustomerReferenceType customerReference { get; set; }

		public AccountingCostCodeType accountingCostCode { get; set; }

		public AccountingCostType accountingCost { get; set; }

		public LineCountNumericType lineCountNumeric { get; set; }

		public PeriodType[] validityPeriod { get; set; }

		public DocumentReferenceType quotationDocumentReference { get; set; }

		public DocumentReferenceType[] orderDocumentReference { get; set; }

		public DocumentReferenceType originatorDocumentReference { get; set; }

		public CatalogueReferenceType catalogueReference { get; set; }

		public DocumentReferenceType[] additionalDocumentReference { get; set; }

		public ContractType[] contract { get; set; }

		public ProjectReferenceType[] projectReference { get; set; }

		public SignatureType[] signature { get; set; }

		public CustomerPartyType buyerCustomerParty { get; set; }

		public SupplierPartyType sellerSupplierParty { get; set; }

		public CustomerPartyType originatorCustomerParty { get; set; }

		public PartyType freightForwarderParty { get; set; }

		public CustomerPartyType accountingCustomerParty { get; set; }

		public DeliveryType[] delivery { get; set; }

		public DeliveryTermsType[] deliveryTerms { get; set; }

		public PaymentMeansType[] paymentMeans { get; set; }

		public PaymentTermsType[] paymentTerms { get; set; }

		public TransactionConditionsType transactionConditions { get; set; }

		public AllowanceChargeType[] allowanceCharge { get; set; }

		public ExchangeRateType taxExchangeRate { get; set; }

		public ExchangeRateType pricingExchangeRate { get; set; }

		public ExchangeRateType paymentExchangeRate { get; set; }

		public CountryType destinationCountry { get; set; }

		public TaxTotalType[] taxTotal { get; set; }

		public MonetaryTotalType anticipatedMonetaryTotal { get; set; }

		public OrderLineType[] orderLine { get; set; }
	}
}