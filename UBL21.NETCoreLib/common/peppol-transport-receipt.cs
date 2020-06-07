
using System.Xml.Serialization;
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    [XmlRoot("PeppolReceipt", Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0", IsNullable = false)]
    public class ReceiptType
    {
        public ReceiptType()
        {
            this.Version = "1.0";
        }

		public string Version { get; set; } = "1.0";

        public string TransmissionId { get; set; }

		public ErrorCodeType ErrorCode { get; set; }

		public TransmissionType Transmission { get; set; }

		public Source Source { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceSpecified { get; set; }

		public PayloadType Payload { get; set; }

		public OriginalReceiptType OriginalReceipt { get; set; }

		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature { get; set; }
	}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public class ErrorCodeType
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ErrorCodeStatus status { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified { get; set; }

		[System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
	}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public enum ErrorCodeStatus { SUCCESS, REJECTED, INVALID_SIGNATURE, UNKNOWN_RECEIVER,}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public class OriginalReceiptType
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }


		[System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }
	}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public class PayloadType
    {
        public string Identifier { get; set; }

        public string ProcessId { get; set; }

		public string DocumentId { get; set; }


		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType DigestMethod { get; set; }


		[XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType = "base64Binary")]
        public byte[] DigestValue { get; set; }
	}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public class ParticipantType
    {
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemeId { get; set; }

		[System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
	}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public class TransmissionType
    {
        public ParticipantType Sender { get; set; }

		/// <remarks/>
		public ParticipantType Receiver { get; set; }

		/// <remarks/>
		public System.DateTime Timestamp { get; set; }


		public string Protocol { get; set; }


		public TransmissionRole Role { get; set; }


		[System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleSpecified { get; set; }
	}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public enum TransmissionRole {C2, C3,}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [XmlType(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    public enum Source {C2, C3, C4,}


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0")]
    [XmlRoot(Namespace = "http://peppol.eu/xsd/ticc/receipt/1.0", IsNullable = false)]
    public class PeppolRemExtension
    {
        public string TransmissionProtocol { get; set; }

		public TransmissionRole TransmissionRole { get; set; }

		[XmlElement("OriginalReceipt")]
        public OriginalReceiptType[] OriginalReceipt { get; set; }
    }
}
