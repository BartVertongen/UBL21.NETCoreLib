
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.main
{
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForwardingInstructions-2")]
	[XmlRootAttribute("ForwardingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForwardingInstructions-2", IsNullable = false)]
	public class ForwardingInstructionsType
	{
		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public CarrierAssignedIDType carrierAssignedID { get; set; }

		public UUIDType uUID { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public NameType name { get; set; }

		public DescriptionType[] description { get; set; }

		public NoteType[] note { get; set; }

		public DocumentStatusCodeType documentStatusCode { get; set; }

		public ShippingOrderIDType shippingOrderID { get; set; }

		public ToOrderIndicatorType toOrderIndicator { get; set; }

		public AdValoremIndicatorType adValoremIndicator { get; set; }

		public DeclaredCarriageValueAmountType declaredCarriageValueAmount { get; set; }

		public OtherInstructionType[] otherInstruction { get; set; }

		public PartyType consignorParty { get; set; }

		public PartyType carrierParty { get; set; }

		public PartyType freightForwarderParty { get; set; }

		public ShipmentType shipment { get; set; }

		public DocumentReferenceType[] documentReference { get; set; }

		public ExchangeRateType[] exchangeRate { get; set; }

		public SignatureType[] signature { get; set; }
	}
}
