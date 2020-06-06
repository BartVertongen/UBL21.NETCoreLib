
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2")]
	[System.Xml.Serialization.XmlRootAttribute("CatalogueDeletion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2", IsNullable = false)]
	public partial class CatalogueDeletionType
	{

		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public UUIDType uUID { get; set; }

		public NameType1 name { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public EffectiveDateType effectiveDate { get; set; }

		public EffectiveTimeType effectiveTime { get; set; }

		public NoteType[] note { get; set; }

		public VersionIDType versionID { get; set; }

		public DescriptionType[] description { get; set; }

		public PeriodType[] validityPeriod { get; set; }

		public CatalogueReferenceType deletedCatalogueReference { get; set; }

		public ContractType[] referencedContract { get; set; }

		public SignatureType[] signature { get; set; }

		public PartyType receiverParty { get; set; }

		public PartyType providerParty { get; set; }

		public SupplierPartyType sellerSupplierParty { get; set; }

		public CustomerPartyType contractorCustomerParty { get; set; }

	}
}