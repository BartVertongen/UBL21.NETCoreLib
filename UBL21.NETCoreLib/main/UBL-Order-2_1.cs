
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Order-2")]
	[XmlRoot("Order", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Order-2", IsNullable = false)]
	public class OrderType
	{
		public UBLExtensionType[] UBLExtensions { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public UBLVersionIDType UBLVersionID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public CustomizationIDType CustomizationID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public ProfileIDType ProfileID { get; set; }

		public ProfileExecutionIDType ProfileExecutionID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IDType ID { get; set; }

		public SalesOrderIDType SalesOrderID { get; set; }

		public CopyIndicatorType CopyIndicator { get; set; }

		public UUIDType UUID { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public IssueDateType IssueDate { get; set; }

		public IssueTimeType IssueTime { get; set; }

		public OrderTypeCodeType OrderTypeCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public NoteType[] Note { get; set; }

		public RequestedInvoiceCurrencyCodeType RequestedInvoiceCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public DocumentCurrencyCodeType DocumentCurrencyCode { get; set; }

		public PricingCurrencyCodeType PricingCurrencyCode { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
		public TaxCurrencyCodeType TaxCurrencyCode { get; set; }

		public CustomerReferenceType CustomerReference { get; set; }

		public AccountingCostCodeType AccountingCostCode { get; set; }

		public AccountingCostType AccountingCost { get; set; }

		public LineCountNumericType LineCountNumeric { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public PeriodType[] ValidityPeriod { get; set; }

		public DocumentReferenceType QuotationDocumentReference { get; set; }

		public DocumentReferenceType[] OrderDocumentReference { get; set; }

		public DocumentReferenceType OriginatorDocumentReference { get; set; }

		public CatalogueReferenceType CatalogueReference { get; set; }

		public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

		public ContractType[] Contract { get; set; }

		public ProjectReferenceType[] ProjectReference { get; set; }

		public SignatureType[] Signature { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public CustomerPartyType BuyerCustomerParty { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public SupplierPartyType SellerSupplierParty { get; set; }

		public CustomerPartyType OriginatorCustomerParty { get; set; }

		public PartyType FreightForwarderParty { get; set; }

		public CustomerPartyType AccountingCustomerParty { get; set; }

		public DeliveryType[] Delivery { get; set; }

		public DeliveryTermsType[] DeliveryTerms { get; set; }

		public PaymentMeansType[] PaymentMeans { get; set; }

		public PaymentTermsType[] PaymentTerms { get; set; }

		public TransactionConditionsType TransactionConditions { get; set; }

		public AllowanceChargeType[] AllowanceCharge { get; set; }

		public ExchangeRateType TaxExchangeRate { get; set; }

		public ExchangeRateType PricingExchangeRate { get; set; }

		public ExchangeRateType PaymentExchangeRate { get; set; }

		public CountryType DestinationCountry { get; set; }

		public TaxTotalType[] TaxTotal { get; set; }

		public MonetaryTotalType AnticipatedMonetaryTotal { get; set; }

		[XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
		public OrderLineType[] OrderLine { get; set; }
	}
}