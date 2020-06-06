
using System.Xml.Serialization;

namespace VertSoft.ubl21.common.CommonExtensionComponents_2
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRootAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UBLExtensionsType
    {

        private UBLExtensionType[] uBLExtensionField;

        [XmlElementAttribute("UBLExtension")]
        public UBLExtensionType[] UBLExtension
        {
            get
            {
                return this.uBLExtensionField;
            }
            set
            {
                this.uBLExtensionField = value;
            }
        }
    }
}