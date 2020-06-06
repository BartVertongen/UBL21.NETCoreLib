
using VertSoft.ubl21.common.CommonAggregateComponents_2;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CommonExtensionComponents_2;


namespace VertSoft.ubl21.main
{

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2")]
	[System.Xml.Serialization.XmlRootAttribute("AttachedDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2", IsNullable = false)]
	public partial class AttachedDocumentType
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

		public NoteType[] note { get; set; }

		public DocumentTypeCodeType documentTypeCode { get; set; }

		public DocumentTypeType documentType { get; set; }

		public ParentDocumentIDType parentDocumentID { get; set; }

		public ParentDocumentTypeCodeType parentDocumentTypeCode { get; set; }

		public ParentDocumentVersionIDType parentDocumentVersionID { get; set; }

		public SignatureType[] signature { get; set; }

		public PartyType senderParty { get; set; }

		public PartyType receiverParty { get; set; }

		public AttachmentType attachment { get; set; }

		public LineReferenceType[] parentDocumentLineReference { get; set; }

	}
}