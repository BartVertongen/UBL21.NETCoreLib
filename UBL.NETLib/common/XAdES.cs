
using VertSoft.ubl21.common.xmldsig;


namespace VertSoft.ubl21.common
{

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("Any", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
    public partial class AnyType {
    
        private System.Xml.XmlNode[] anyField;
    
        private System.Xml.XmlAttribute[] anyAttrField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class NoticeReferenceType {
    
        private string organizationField;
    
        private string[] noticeNumbersField;
    
        /// <remarks/>
        public string Organization {
            get {
                return this.organizationField;
            }
            set {
                this.organizationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("int", DataType="integer", IsNullable=false)]
        public string[] NoticeNumbers {
            get {
                return this.noticeNumbersField;
            }
            set {
                this.noticeNumbersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ResponderIDType {
    
        private object itemField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ByKey", typeof(byte[]), DataType="base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("ByName", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OCSPIdentifierType {
    
        private ResponderIDType responderIDField;
    
        private System.DateTime producedAtField;
    
        private string uRIField;
    
        /// <remarks/>
        public ResponderIDType ResponderID {
            get {
                return this.responderIDField;
            }
            set {
                this.responderIDField = value;
            }
        }
    
        /// <remarks/>
        public System.DateTime ProducedAt {
            get {
                return this.producedAtField;
            }
            set {
                this.producedAtField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OCSPRefType {
    
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DigestAlgAndValueType {
    
        private DigestMethodType digestMethodField;
    
        private byte[] digestValueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLIdentifierType {
    
        private string issuerField;
    
        private System.DateTime issueTimeField;
    
        private string numberField;
    
        private string uRIField;
    
        /// <remarks/>
        public string Issuer {
            get {
                return this.issuerField;
            }
            set {
                this.issuerField = value;
            }
        }
    
        /// <remarks/>
        public System.DateTime IssueTime {
            get {
                return this.issueTimeField;
            }
            set {
                this.issueTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLRefType {
    
        private DigestAlgAndValueType digestAlgAndValueField;
    
        private CRLIdentifierType cRLIdentifierField;
    
        /// <remarks/>
        public DigestAlgAndValueType DigestAlgAndValue {
            get {
                return this.digestAlgAndValueField;
            }
            set {
                this.digestAlgAndValueField = value;
            }
        }
    
        /// <remarks/>
        public CRLIdentifierType CRLIdentifier {
            get {
                return this.cRLIdentifierField;
            }
            set {
                this.cRLIdentifierField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignaturePolicyIdType {
    
        private ObjectIdentifierType sigPolicyIdField;
    
        private TransformType[] transformsField;
    
        private DigestAlgAndValueType sigPolicyHashField;
    
        private AnyType[] sigPolicyQualifiersField;
    
        /// <remarks/>
        public ObjectIdentifierType SigPolicyId {
            get {
                return this.sigPolicyIdField;
            }
            set {
                this.sigPolicyIdField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public TransformType[] Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
    
        /// <remarks/>
        public DigestAlgAndValueType SigPolicyHash {
            get {
                return this.sigPolicyHashField;
            }
            set {
                this.sigPolicyHashField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable=false)]
        public AnyType[] SigPolicyQualifiers {
            get {
                return this.sigPolicyQualifiersField;
            }
            set {
                this.sigPolicyQualifiersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("ObjectIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
    public partial class ObjectIdentifierType {
    
        private IdentifierType identifierField;
    
        private string descriptionField;
    
        private DocumentationReferencesType documentationReferencesField;
    
        /// <remarks/>
        public IdentifierType Identifier {
            get {
                return this.identifierField;
            }
            set {
                this.identifierField = value;
            }
        }
    
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
        public DocumentationReferencesType DocumentationReferences {
            get {
                return this.documentationReferencesField;
            }
            set {
                this.documentationReferencesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IdentifierType {
    
        private QualifierType qualifierField;
    
        private bool qualifierFieldSpecified;
    
        private string valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QualifierType Qualifier {
            get {
                return this.qualifierField;
            }
            set {
                this.qualifierField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifierSpecified {
            get {
                return this.qualifierFieldSpecified;
            }
            set {
                this.qualifierFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public enum QualifierType {
    
        /// <remarks/>
        OIDAsURI,
    
        /// <remarks/>
        OIDAsURN,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DocumentationReferencesType {
    
        private string[] documentationReferenceField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentationReference", DataType="anyURI")]
        public string[] DocumentationReference {
            get {
                return this.documentationReferenceField;
            }
            set {
                this.documentationReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertIDType {
    
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
[System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
public abstract partial class GenericTimeStampType {
    
    private object[] itemsField;
    
    private CanonicalizationMethodType canonicalizationMethodField;
    
    private object[] items1Field;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public CanonicalizationMethodType CanonicalizationMethod {
        get {
            return this.canonicalizationMethodField;
        }
        set {
            this.canonicalizationMethodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
    [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("Include", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class IncludeType {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("ReferenceInfo", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class ReferenceInfoType {
    
    private DigestMethodType digestMethodField;
    
    private byte[] digestValueField;
    
    private string idField;
    
    private string uRIField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public DigestMethodType DigestMethod {
        get {
            return this.digestMethodField;
        }
        set {
            this.digestMethodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("EncapsulatedPKIData", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class EncapsulatedPKIDataType {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("XAdESTimeStamp", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class XAdESTimeStampType : GenericTimeStampType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("OtherTimeStamp", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class OtherTimeStampType : GenericTimeStampType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("QualifyingProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class QualifyingPropertiesType {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedPropertiesType {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedSignaturePropertiesType {
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignaturePolicyIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignaturePolicyIdentifierType {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyId", typeof(SignaturePolicyIdType))]
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyImplied", typeof(object))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignatureProductionPlaceType {
    
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignerRole", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignerRoleType {
    
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedDataObjectPropertiesType {
    
    private DataObjectFormatType[] dataObjectFormatField;
    
    private CommitmentTypeIndicationType[] commitmentTypeIndicationField;
    
    private XAdESTimeStampType[] allDataObjectsTimeStampField;
    
    private XAdESTimeStampType[] individualDataObjectsTimeStampField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
    public DataObjectFormatType[] DataObjectFormat {
        get {
            return this.dataObjectFormatField;
        }
        set {
            this.dataObjectFormatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
    public CommitmentTypeIndicationType[] CommitmentTypeIndication {
        get {
            return this.commitmentTypeIndicationField;
        }
        set {
            this.commitmentTypeIndicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
    public XAdESTimeStampType[] AllDataObjectsTimeStamp {
        get {
            return this.allDataObjectsTimeStampField;
        }
        set {
            this.allDataObjectsTimeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("DataObjectFormat", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class DataObjectFormatType {
    
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
    [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CommitmentTypeIndicationType {
    
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
    [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType="anyURI")]
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class UnsignedPropertiesType {
    
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
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("UnsignedSignatureProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class UnsignedSignaturePropertiesType {
    
    private object[] itemsField;
    
    private ItemsChoiceType3[] itemsElementNameField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("ArchiveTimeStamp", typeof(XAdESTimeStampType))]
    [System.Xml.Serialization.XmlElementAttribute("AttrAuthoritiesCertValues", typeof(CertificateValuesType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeCertificateRefs", typeof(CompleteCertificateRefsType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationRefs", typeof(CompleteRevocationRefsType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationValues", typeof(RevocationValuesType))]
    [System.Xml.Serialization.XmlElementAttribute("CertificateValues", typeof(CertificateValuesType))]
    [System.Xml.Serialization.XmlElementAttribute("CompleteCertificateRefs", typeof(CompleteCertificateRefsType))]
    [System.Xml.Serialization.XmlElementAttribute("CompleteRevocationRefs", typeof(CompleteRevocationRefsType))]
    [System.Xml.Serialization.XmlElementAttribute("CounterSignature", typeof(CounterSignatureType))]
    [System.Xml.Serialization.XmlElementAttribute("RefsOnlyTimeStamp", typeof(XAdESTimeStampType))]
    [System.Xml.Serialization.XmlElementAttribute("RevocationValues", typeof(RevocationValuesType))]
    [System.Xml.Serialization.XmlElementAttribute("SigAndRefsTimeStamp", typeof(XAdESTimeStampType))]
    [System.Xml.Serialization.XmlElementAttribute("SignatureTimeStamp", typeof(XAdESTimeStampType))]
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
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CertificateValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CertificateValuesType {
    
    private object[] itemsField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
    [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType))]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CompleteCertificateRefs", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CompleteCertificateRefsType {
    
    private CertIDType[] certRefsField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
    public CertIDType[] CertRefs {
        get {
            return this.certRefsField;
        }
        set {
            this.certRefsField = value;
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


	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("CompleteRevocationRefs", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class CompleteRevocationRefsType
	{
		[System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable=false)]
		public CRLRefType[] CRLRefs { get; set; }

		[System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable=false)]
		public OCSPRefType[] OCSPRefs { get; set; }

		[System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable=false)]
		public AnyType[] OtherRefs { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}


	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("RevocationValues", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class RevocationValuesType
	{
		[System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] CRLValues { get; set; }

		[System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
		public EncapsulatedPKIDataType[] OCSPValues { get; set; }

		[System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
		public AnyType[] OtherValues { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("CounterSignature", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class CounterSignatureType
	{

		[System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
		public SignatureType Signature { get; set; }
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#", IncludeInSchema=false)]
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


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("UnsignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class UnsignedDataObjectPropertiesType
	{   
		[System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperty")]
		public AnyType[] UnsignedDataObjectProperty { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("QualifyingPropertiesReference", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class QualifyingPropertiesReferenceType
	{   
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
		public string URI { get; set; }

		[System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
		public string Id { get; set; }
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SigningCertificate", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class CertIDListType
	{   
		[System.Xml.Serialization.XmlElementAttribute("Cert")]
		public CertIDType[] Cert { get; set; }
	}


	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
	[System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
	public partial class SPUserNoticeType
	{
		public NoticeReferenceType NoticeRef { get; set; }

		public string ExplicitText { get; set; }
	}
}