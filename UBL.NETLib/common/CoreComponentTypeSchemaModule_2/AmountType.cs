
using System.Xml.Serialization;
using VertSoft.ubl21.common.CommonBasicComponents_2;
using VertSoft.ubl21.common.UnqualifiedDataTypes_2;

namespace VertSoft.ubl21.common.CoreComponentTypeSchemaModule_2
{
    [XmlIncludeAttribute(typeof(AmountType1))]
    [XmlIncludeAttribute(typeof(ValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionCurrencyTaxAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalTaxAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalTaskAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalPaymentAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalInvoiceAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalDebitAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalCreditAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalBalanceAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThresholdAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxableAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxInclusiveAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxExclusiveAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxEnergyOnAccountAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxEnergyBalanceAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxEnergyAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettlementDiscountAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoundingAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredFeeAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PriceAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepaidAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerUnitAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PenaltyAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayableRoundingAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayableAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayableAlternativeAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartyCapacityAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaidAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumPaidAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumAdvertisementAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LowerTenderAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineExtensionAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LiabilityAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InventoryValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsurancePremiumAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HigherTenderAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FreeOnBoardValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeeAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedOverallContractAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentationFeeAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclaredStatisticsValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclaredForCarriageValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclaredCustomsValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclaredCarriageValueAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DebitLineAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditLineAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CorrectionUnitAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CorrectionAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CorporateStockAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeTotalAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallExtensionAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallBaseAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BalanceAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AverageSubsequentContractAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AverageAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnnualAverageAmountType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountType2))]
    [XmlIncludeAttribute(typeof(AllowanceTotalAmountType))]
    [XmlIncludeAttribute(typeof(AdvertisementAmountType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class AmountType
    {

        private string currencyIDField;

        private string currencyCodeListVersionIDField;

        private decimal valueField;

        [XmlAttributeAttribute(DataType = "normalizedString")]
        public string currencyID
        {
            get
            {
                return this.currencyIDField;
            }
            set
            {
                this.currencyIDField = value;
            }
        }


        [XmlAttributeAttribute(DataType = "normalizedString")]
        public string currencyCodeListVersionID
        {
            get
            {
                return this.currencyCodeListVersionIDField;
            }
            set
            {
                this.currencyCodeListVersionIDField = value;
            }
        }

        [XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}