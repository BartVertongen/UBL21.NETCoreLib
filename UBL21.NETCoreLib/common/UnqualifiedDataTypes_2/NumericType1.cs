
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2;


namespace VertSoft.ubl21.common.UnqualifiedDataTypes_2
{
    [XmlInclude(typeof(WeightNumericType))]
    [XmlInclude(typeof(SequenceNumericType))]
    [XmlInclude(typeof(ResidentOccupantsNumericType))]
    [XmlInclude(typeof(ReminderSequenceNumericType))]
    [XmlInclude(typeof(PackSizeNumericType))]
    [XmlInclude(typeof(OrderQuantityIncrementNumericType))]
    [XmlInclude(typeof(OrderIntervalDaysNumericType))]
    [XmlInclude(typeof(MultiplierFactorNumericType))]
    [XmlInclude(typeof(MinimumNumberNumericType))]
    [XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlInclude(typeof(MaximumNumberNumericType))]
    [XmlInclude(typeof(MaximumCopiesNumericType))]
    [XmlInclude(typeof(LineNumberNumericType))]
    [XmlInclude(typeof(LineCountNumericType))]
    [XmlInclude(typeof(FrozenPeriodDaysNumericType))]
    [XmlInclude(typeof(CalculationSequenceNumericType))]
    [XmlInclude(typeof(BudgetYearNumericType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName = "NumericType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NumericType1 : NumericType
    {
    }
}