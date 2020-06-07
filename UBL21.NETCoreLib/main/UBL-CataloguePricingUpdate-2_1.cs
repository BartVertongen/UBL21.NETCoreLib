
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2")]
	[XmlRoot("CataloguePricingUpdate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2", IsNullable = false)]
	public class CataloguePricingUpdateType
	{
		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public UUIDType uUID { get; set; }

		public NameType name { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public RevisionDateType revisionDate { get; set; }

		public RevisionTimeType revisionTime { get; set; }

		public NoteType[] note { get; set; }

		public DescriptionType[] description { get; set; }

		public VersionIDType versionID { get; set; }

		public LineCountNumericType lineCountNumeric { get; set; }

		public PeriodType[] validityPeriod { get; set; }

		public CatalogueReferenceType relatedCatalogueReference { get; set; }

		public ContractType[] referencedContract { get; set; }

		public SignatureType[] signature { get; set; }

		public PartyType providerParty { get; set; }

		public PartyType receiverParty { get; set; }

		public SupplierPartyType sellerSupplierParty { get; set; }

		public CustomerPartyType contractorCustomerParty { get; set; }

		public TradingTermsType tradingTerms { get; set; }

		public LanguageType defaultLanguage { get; set; }

		public CataloguePricingUpdateLineType[] cataloguePricingUpdateLine { get; set; }

	}
}