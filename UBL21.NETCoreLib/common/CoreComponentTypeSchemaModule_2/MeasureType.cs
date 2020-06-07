
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;


namespace VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2
{
    [XmlInclude(typeof(MeasureType1))]
    [XmlInclude(typeof(ValueMeasureType))]
    [XmlInclude(typeof(TareWeightMeasureType))]
    [XmlInclude(typeof(SourceValueMeasureType))]
    [XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(NetWeightMeasureType))]
    [XmlInclude(typeof(NetVolumeMeasureType))]
    [XmlInclude(typeof(NetTonnageMeasureType))]
    [XmlInclude(typeof(NetNetWeightMeasureType))]
    [XmlInclude(typeof(MinimumMeasureType))]
    [XmlInclude(typeof(MeasureType2))]
    [XmlInclude(typeof(MaximumMeasureType))]
    [XmlInclude(typeof(LongitudeMinutesMeasureType))]
    [XmlInclude(typeof(LongitudeDegreesMeasureType))]
    [XmlInclude(typeof(LoadingLengthMeasureType))]
    [XmlInclude(typeof(LeadTimeMeasureType))]
    [XmlInclude(typeof(LatitudeMinutesMeasureType))]
    [XmlInclude(typeof(LatitudeDegreesMeasureType))]
    [XmlInclude(typeof(GrossWeightMeasureType))]
    [XmlInclude(typeof(GrossVolumeMeasureType))]
    [XmlInclude(typeof(GrossTonnageMeasureType))]
    [XmlInclude(typeof(DurationMeasureType))]
    [XmlInclude(typeof(ComparedValueMeasureType))]
    [XmlInclude(typeof(ChargeableWeightMeasureType))]
    [XmlInclude(typeof(BaseUnitMeasureType))]
    [XmlInclude(typeof(AltitudeMeasureType))]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class MeasureType
    {
        [XmlAttribute(DataType = "normalizedString")]
        public string unitCode { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string unitCodeListVersionID { get; set; }

        [XmlText()]
        public decimal Value { get; set; }
    }
}