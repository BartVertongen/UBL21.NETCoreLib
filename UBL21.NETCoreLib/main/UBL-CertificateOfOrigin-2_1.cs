
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2")]
	[XmlRoot("CertificateOfOrigin", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2", IsNullable = false)]
	public class CertificateOfOriginType
	{
		public UBLExtensionType[] uBLExtensions { get; set; }

		public UBLVersionIDType uBLVersionID { get; set; }

		public CustomizationIDType customizationID { get; set; }

		public ProfileIDType profileID { get; set; }

		public ProfileExecutionIDType profileExecutionID { get; set; }

		public IDType id { get; set; }

		public UUIDType uUID { get; set; }

		public IssueDateType issueDate { get; set; }

		public IssueTimeType issueTime { get; set; }

		public DescriptionType[] description { get; set; }

		public NoteType[] note { get; set; }

		public VersionIDType versionID { get; set; }

		public SignatureType[] signature { get; set; }

		public PartyType exporterParty { get; set; }

		public PartyType importerParty { get; set; }

		public EndorserPartyType[] endorserParty { get; set; }

		public CertificateOfOriginApplicationType certificateOfOriginApplication { get; set; }

		public EndorsementType issuerEndorsement { get; set; }

		public EndorsementType embassyEndorsement { get; set; }

		public EndorsementType insuranceEndorsement { get; set; }
	}
}