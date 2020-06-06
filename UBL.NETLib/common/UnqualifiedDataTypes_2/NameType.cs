
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;

namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [XmlIncludeAttribute(typeof(VesselNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnicalNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoamingPartnerNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RetailEventNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MiddleNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HolderNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirstNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FileNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FamilyNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitySubdivisionNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CityNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BrandNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlockNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AliasNameType))]
    [XmlIncludeAttribute(typeof(AdditionalStreetNameType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NameType : TextType
    {
    }
}