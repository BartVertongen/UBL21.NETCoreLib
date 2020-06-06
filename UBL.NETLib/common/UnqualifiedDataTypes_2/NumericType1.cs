
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;


namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeightNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SequenceNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResidentOccupantsNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReminderSequenceNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PackSizeNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuantityIncrementNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderIntervalDaysNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiplierFactorNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumPaymentInstructionsNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumCopiesNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineCountNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrozenPeriodDaysNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationSequenceNumericType))]
    [XmlIncludeAttribute(typeof(BudgetYearNumericType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "NumericType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NumericType1 : NumericType
    {
    }
}