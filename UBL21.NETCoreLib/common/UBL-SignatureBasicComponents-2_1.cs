

using System.Xml.Serialization;


[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ReferencedSignatureID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2", IsNullable=false)]
public partial class ReferencedSignatureIDType : IdentifierType1 {}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="IdentifierType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
public partial class IdentifierType1 : IdentifierType {
}


[System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentifierType1))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public class IdentifierType {
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeID { get; set; }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schemeName { get; set; }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeAgencyID { get; set; }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schemeAgencyName { get; set; }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
    public string schemeVersionID { get; set; }
    

    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string schemeDataURI { get; set; }
    

    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string schemeURI { get; set; }
    
    [System.Xml.Serialization.XmlTextAttribute(DataType="normalizedString")]
    public string Value { get; set; }
}
