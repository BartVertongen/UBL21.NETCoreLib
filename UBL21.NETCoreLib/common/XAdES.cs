
using System.Xml;
using System.Xml.Serialization;
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common
{

    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRoot("Any", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
    public class AnyType
	{
        [XmlTextAttribute()]
        [XmlAnyElementAttribute()]
        public XmlNode[] Any { get; set; }

		/// <remarks/>
		[XmlAnyAttributeAttribute()]
        public XmlAttribute[] AnyAttr { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class NoticeReferenceType
	{
        public string Organization { get; set; }

		[XmlArrayItem("int", DataType="integer", IsNullable=false)]
        public string[] NoticeNumbers { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class ResponderIDType
	{
    
        private object itemField;
    
        /// <remarks/>
        [XmlElement("ByKey", typeof(byte[]), DataType="base64Binary")]
        [XmlElement("ByName", typeof(string))]
        public object Item { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class OCSPIdentifierType
	{
        public ResponderIDType ResponderID { get; set; }

		public System.DateTime ProducedAt { get; set; }

		[XmlAttribute(DataType="anyURI")]
        public string URI { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class OCSPRefType {
    
        private OCSPIdentifierType oCSPIdentifierField;
    
        private DigestAlgAndValueType digestAlgAndValueField;
    
        /// <remarks/>
        public OCSPIdentifierType OCSPIdentifier {
            get {
                return this.oCSPIdentifierField;
            }
            set {
                this.oCSPIdentifierField = value;
            }
        }
    
        /// <remarks/>
        public DigestAlgAndValueType DigestAlgAndValue {
            get {
                return this.digestAlgAndValueField;
            }
            set {
                this.digestAlgAndValueField = value;
            }
        }
    }


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class DigestAlgAndValueType
	{
        [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType DigestMethod { get; set; }


		[XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
        public byte[] DigestValue { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class CRLIdentifierType 
	{
        public string Issuer { get; set; }

		public System.DateTime IssueTime { get; set; }


		[XmlElement(DataType="integer")]
        public string Number { get; set; }


		[XmlAttribute(DataType="anyURI")]
        public string URI { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class CRLRefType
	{
        public DigestAlgAndValueType DigestAlgAndValue { get; set; }

		public CRLIdentifierType CRLIdentifier { get; set; }
	}



    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class SignaturePolicyIdType
	{
        public ObjectIdentifierType SigPolicyId { get; set; }

		[XmlArray(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        [XmlArrayItem("Transform", IsNullable=false)]
        public TransformType[] Transforms { get; set; }

		public DigestAlgAndValueType SigPolicyHash { get; set; }

		[XmlArrayItem("SigPolicyQualifier", IsNullable=false)]
        public AnyType[] SigPolicyQualifiers { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRoot("ObjectIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
    public class ObjectIdentifierType
	{
    
        private IdentifierType identifierField;
    
        private string descriptionField;
    
        private DocumentationReferencesType documentationReferencesField;
    
        /// <remarks/>
        public IdentifierType Identifier { get; set; }

		/// <remarks/>
		public string Description { get; set; }

		/// <remarks/>
		public DocumentationReferencesType DocumentationReferences { get; set; }
	}


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class IdentifierType {
    
        private QualifierType qualifierField;
    
        private bool qualifierFieldSpecified;
    
        private string valueField;
    
        /// <remarks/>
        [XmlAttributeAttribute()]
        public QualifierType Qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QualifierSpecified {
            get {
                return this.qualifierFieldSpecified;
            }
            set {
                this.qualifierFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [XmlTextAttribute(DataType="anyURI")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }


    [System.Serializable()]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public enum QualifierType {
        OIDAsURI,
        OIDAsURN,
    }


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class DocumentationReferencesType {
    
        private string[] documentationReferenceField;
    
        /// <remarks/>
        [XmlElement("DocumentationReference", DataType="anyURI")]
        public string[] DocumentationReference {
            get {
                return this.documentationReferenceField;
            }
            set {
                this.documentationReferenceField = value;
            }
        }
    }


    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public class CertIDType {
    
        private DigestAlgAndValueType certDigestField;
    
        private X509IssuerSerialType issuerSerialField;
    
        private string uRIField;
    
        /// <remarks/>
        public DigestAlgAndValueType CertDigest {
            get {
                return this.certDigestField;
            }
            set {
                this.certDigestField = value;
            }
        }
    
        /// <remarks/>
        public X509IssuerSerialType IssuerSerial {
            get {
                return this.issuerSerialField;
            }
            set {
                this.issuerSerialField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
    }

/// <remarks/>
[XmlInclude(typeof(OtherTimeStampType))]
[XmlInclude(typeof(XAdESTimeStampType))]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
public abstract partial class GenericTimeStampType {
    
    private object[] itemsField;
    
    private CanonicalizationMethodType canonicalizationMethodField;
    
    private object[] items1Field;
    
    private string idField;
    
    /// <remarks/>
    [XmlElement("Include", typeof(IncludeType))]
    [XmlElement("ReferenceInfo", typeof(ReferenceInfoType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public CanonicalizationMethodType CanonicalizationMethod {
        get {
            return this.canonicalizationMethodField;
        }
        set {
            this.canonicalizationMethodField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
    [XmlElement("XMLTimeStamp", typeof(AnyType))]
    public object[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("Include", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class IncludeType {
    
    private string uRIField;
    
    private bool referencedDataField;
    
    private bool referencedDataFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string URI {
        get {
            return this.uRIField;
        }
        set {
            this.uRIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool referencedData {
        get {
            return this.referencedDataField;
        }
        set {
            this.referencedDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool referencedDataSpecified {
        get {
            return this.referencedDataFieldSpecified;
        }
        set {
            this.referencedDataFieldSpecified = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("ReferenceInfo", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class ReferenceInfoType {
    
    private DigestMethodType digestMethodField;
    
    private byte[] digestValueField;
    
    private string idField;
    
    private string uRIField;
    
    /// <remarks/>
    [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public DigestMethodType DigestMethod {
        get {
            return this.digestMethodField;
        }
        set {
            this.digestMethodField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
    public byte[] DigestValue {
        get {
            return this.digestValueField;
        }
        set {
            this.digestValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string URI {
        get {
            return this.uRIField;
        }
        set {
            this.uRIField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("EncapsulatedPKIData", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class EncapsulatedPKIDataType {
    
    private string idField;
    
    private string encodingField;
    
    private byte[] valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string Encoding {
        get {
            return this.encodingField;
        }
        set {
            this.encodingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("XAdESTimeStamp", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class XAdESTimeStampType : GenericTimeStampType {
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("OtherTimeStamp", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class OtherTimeStampType : GenericTimeStampType {
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("QualifyingProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class QualifyingPropertiesType {
    
    private SignedPropertiesType signedPropertiesField;
    
    private UnsignedPropertiesType unsignedPropertiesField;
    
    private string targetField;
    
    private string idField;
    
    /// <remarks/>
    public SignedPropertiesType SignedProperties {
        get {
            return this.signedPropertiesField;
        }
        set {
            this.signedPropertiesField = value;
        }
    }
    
    /// <remarks/>
    public UnsignedPropertiesType UnsignedProperties {
        get {
            return this.unsignedPropertiesField;
        }
        set {
            this.unsignedPropertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string Target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignedPropertiesType {
    
    private SignedSignaturePropertiesType signedSignaturePropertiesField;
    
    private SignedDataObjectPropertiesType signedDataObjectPropertiesField;
    
    private string idField;
    
    /// <remarks/>
    public SignedSignaturePropertiesType SignedSignatureProperties {
        get {
            return this.signedSignaturePropertiesField;
        }
        set {
            this.signedSignaturePropertiesField = value;
        }
    }
    
    /// <remarks/>
    public SignedDataObjectPropertiesType SignedDataObjectProperties {
        get {
            return this.signedDataObjectPropertiesField;
        }
        set {
            this.signedDataObjectPropertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignedSignaturePropertiesType {
    
    private System.DateTime signingTimeField;
    
    private bool signingTimeFieldSpecified;
    
    private CertIDType[] signingCertificateField;
    
    private SignaturePolicyIdentifierType signaturePolicyIdentifierField;
    
    private SignatureProductionPlaceType signatureProductionPlaceField;
    
    private SignerRoleType signerRoleField;
    
    private string idField;
    
    /// <remarks/>
    public System.DateTime SigningTime {
        get {
            return this.signingTimeField;
        }
        set {
            this.signingTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SigningTimeSpecified {
        get {
            return this.signingTimeFieldSpecified;
        }
        set {
            this.signingTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
    public CertIDType[] SigningCertificate {
        get {
            return this.signingCertificateField;
        }
        set {
            this.signingCertificateField = value;
        }
    }
    
    /// <remarks/>
    public SignaturePolicyIdentifierType SignaturePolicyIdentifier {
        get {
            return this.signaturePolicyIdentifierField;
        }
        set {
            this.signaturePolicyIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public SignatureProductionPlaceType SignatureProductionPlace {
        get {
            return this.signatureProductionPlaceField;
        }
        set {
            this.signatureProductionPlaceField = value;
        }
    }
    
    /// <remarks/>
    public SignerRoleType SignerRole {
        get {
            return this.signerRoleField;
        }
        set {
            this.signerRoleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignaturePolicyIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignaturePolicyIdentifierType {
    
    private object itemField;
    
    /// <remarks/>
    [XmlElement("SignaturePolicyId", typeof(SignaturePolicyIdType))]
    [XmlElement("SignaturePolicyImplied", typeof(object))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignatureProductionPlace", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignatureProductionPlaceType {
    
    private string cityField;
    
    private string stateOrProvinceField;
    
    private string postalCodeField;
    
    private string countryNameField;
    
    /// <remarks/>
    public string City {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public string StateOrProvince {
        get {
            return this.stateOrProvinceField;
        }
        set {
            this.stateOrProvinceField = value;
        }
    }
    
    /// <remarks/>
    public string PostalCode {
        get {
            return this.postalCodeField;
        }
        set {
            this.postalCodeField = value;
        }
    }
    
    /// <remarks/>
    public string CountryName {
        get {
            return this.countryNameField;
        }
        set {
            this.countryNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignerRole", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignerRoleType {
    
    private AnyType[] claimedRolesField;
    
    private EncapsulatedPKIDataType[] certifiedRolesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable=false)]
    public AnyType[] ClaimedRoles {
        get {
            return this.claimedRolesField;
        }
        set {
            this.claimedRolesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable=false)]
    public EncapsulatedPKIDataType[] CertifiedRoles {
        get {
            return this.certifiedRolesField;
        }
        set {
            this.certifiedRolesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class SignedDataObjectPropertiesType {
    
    private DataObjectFormatType[] dataObjectFormatField;
    
    private CommitmentTypeIndicationType[] commitmentTypeIndicationField;
    
    private XAdESTimeStampType[] allDataObjectsTimeStampField;
    
    private XAdESTimeStampType[] individualDataObjectsTimeStampField;
    
    private string idField;
    
    /// <remarks/>
    [XmlElement("DataObjectFormat")]
    public DataObjectFormatType[] DataObjectFormat {
        get {
            return this.dataObjectFormatField;
        }
        set {
            this.dataObjectFormatField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("CommitmentTypeIndication")]
    public CommitmentTypeIndicationType[] CommitmentTypeIndication {
        get {
            return this.commitmentTypeIndicationField;
        }
        set {
            this.commitmentTypeIndicationField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("AllDataObjectsTimeStamp")]
    public XAdESTimeStampType[] AllDataObjectsTimeStamp {
        get {
            return this.allDataObjectsTimeStampField;
        }
        set {
            this.allDataObjectsTimeStampField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("IndividualDataObjectsTimeStamp")]
    public XAdESTimeStampType[] IndividualDataObjectsTimeStamp {
        get {
            return this.individualDataObjectsTimeStampField;
        }
        set {
            this.individualDataObjectsTimeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("DataObjectFormat", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class DataObjectFormatType {
    
    private string descriptionField;
    
    private ObjectIdentifierType objectIdentifierField;
    
    private string mimeTypeField;
    
    private string encodingField;
    
    private string objectReferenceField;
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ObjectIdentifierType ObjectIdentifier {
        get {
            return this.objectIdentifierField;
        }
        set {
            this.objectIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public string MimeType {
        get {
            return this.mimeTypeField;
        }
        set {
            this.mimeTypeField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement(DataType="anyURI")]
    public string Encoding {
        get {
            return this.encodingField;
        }
        set {
            this.encodingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string ObjectReference {
        get {
            return this.objectReferenceField;
        }
        set {
            this.objectReferenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("CommitmentTypeIndication", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class CommitmentTypeIndicationType {
    
    private ObjectIdentifierType commitmentTypeIdField;
    
    private object[] itemsField;
    
    private AnyType[] commitmentTypeQualifiersField;
    
    /// <remarks/>
    public ObjectIdentifierType CommitmentTypeId {
        get {
            return this.commitmentTypeIdField;
        }
        set {
            this.commitmentTypeIdField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("AllSignedDataObjects", typeof(object))]
    [XmlElement("ObjectReference", typeof(string), DataType="anyURI")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable=false)]
    public AnyType[] CommitmentTypeQualifiers {
        get {
            return this.commitmentTypeQualifiersField;
        }
        set {
            this.commitmentTypeQualifiersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("UnsignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class UnsignedPropertiesType {
    
    private UnsignedSignaturePropertiesType unsignedSignaturePropertiesField;
    
    private UnsignedDataObjectPropertiesType unsignedDataObjectPropertiesField;
    
    private string idField;
    
    /// <remarks/>
    public UnsignedSignaturePropertiesType UnsignedSignatureProperties {
        get {
            return this.unsignedSignaturePropertiesField;
        }
        set {
            this.unsignedSignaturePropertiesField = value;
        }
    }
    
    /// <remarks/>
    public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties {
        get {
            return this.unsignedDataObjectPropertiesField;
        }
        set {
            this.unsignedDataObjectPropertiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("UnsignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class UnsignedSignaturePropertiesType {
    
    private object[] itemsField;
    
    private ItemsChoiceType3[] itemsElementNameField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [XmlElement("ArchiveTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("AttrAuthoritiesCertValues", typeof(CertificateValuesType))]
    [XmlElement("AttributeCertificateRefs", typeof(CompleteCertificateRefsType))]
    [XmlElement("AttributeRevocationRefs", typeof(CompleteRevocationRefsType))]
    [XmlElement("AttributeRevocationValues", typeof(RevocationValuesType))]
    [XmlElement("CertificateValues", typeof(CertificateValuesType))]
    [XmlElement("CompleteCertificateRefs", typeof(CompleteCertificateRefsType))]
    [XmlElement("CompleteRevocationRefs", typeof(CompleteRevocationRefsType))]
    [XmlElement("CounterSignature", typeof(CounterSignatureType))]
    [XmlElement("RefsOnlyTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("RevocationValues", typeof(RevocationValuesType))]
    [XmlElement("SigAndRefsTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("SignatureTimeStamp", typeof(XAdESTimeStampType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [XmlElement("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType3[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("CertificateValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class CertificateValuesType {
    
    private object[] itemsField;
    
    private string idField;
    
    /// <remarks/>
    [XmlElement("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
    [XmlElement("OtherCertificate", typeof(AnyType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


[System.Serializable()]
[System.Diagnostics.DebuggerStepThrough()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("CompleteCertificateRefs", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public class CompleteCertificateRefsType {
    
    private CertIDType[] certRefsField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
    public CertIDType[] CertRefs { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("CompleteRevocationRefs", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class CompleteRevocationRefsType
	{
		[XmlArrayItemAttribute("CRLRef", IsNullable=false)]
		public CRLRefType[] CRLRefs { get; set; }

		[XmlArrayItemAttribute("OCSPRef", IsNullable=false)]
		public OCSPRefType[] OCSPRefs { get; set; }

		[XmlArrayItemAttribute("OtherRef", IsNullable=false)]
		public AnyType[] OtherRefs { get; set; }

		[XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("RevocationValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class RevocationValuesType
	{
		[XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] CRLValues { get; set; }

		[XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] OCSPValues { get; set; }

		[XmlArrayItemAttribute("OtherValue", IsNullable=false)]
		public AnyType[] OtherValues { get; set; }

		[XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}


	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("CounterSignature", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class CounterSignatureType
	{

		[XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature { get; set; }
	}


	[System.Serializable()]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#", IncludeInSchema=false)]
	public enum ItemsChoiceType3
	{  
		[System.Xml.Serialization.XmlEnumAttribute("##any:")]
		Item,    
		ArchiveTimeStamp,   
		AttrAuthoritiesCertValues,
		AttributeCertificateRefs,
		AttributeRevocationRefs,
		AttributeRevocationValues,
		CertificateValues,
		CompleteCertificateRefs,
		CompleteRevocationRefs,
		CounterSignature,
		RefsOnlyTimeStamp,
		RevocationValues,    
		SigAndRefsTimeStamp,    
		SignatureTimeStamp,
	}



	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("UnsignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class UnsignedDataObjectPropertiesType
	{   
		[XmlElement("UnsignedDataObjectProperty")]
		public AnyType[] UnsignedDataObjectProperty { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}



	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("QualifyingPropertiesReference", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class QualifyingPropertiesReferenceType
	{   
		[XmlAttribute(DataType="anyURI")]
		public string URI { get; set; }

		[XmlAttribute(DataType="ID")]
		public string Id { get; set; }
	}



	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("SigningCertificate", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class CertIDListType
	{   
		[XmlElement("Cert")]
		public CertIDType[] Cert { get; set; }
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[XmlRoot("SPUserNotice", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public class SPUserNoticeType
	{
		public NoticeReferenceType NoticeRef { get; set; }

		public string ExplicitText { get; set; }
	}
}