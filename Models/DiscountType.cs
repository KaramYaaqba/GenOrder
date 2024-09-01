    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DiscountType
    {
        
        private string discountType1Field;
        
        private AmountType amountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscountType" )]
        public string DiscountType1
        {
            get
            {
                return this.discountType1Field;
            }
            set
            {
                this.discountType1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }
