    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NettedTransactionSummaryType
    {
        
        private AmountType totalNettedChargeAmountField;
        
        private AmountType totalNettedCreditAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalNettedChargeAmount
        {
            get
            {
                return this.totalNettedChargeAmountField;
            }
            set
            {
                this.totalNettedChargeAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalNettedCreditAmount
        {
            get
            {
                return this.totalNettedCreditAmountField;
            }
            set
            {
                this.totalNettedCreditAmountField = value;
            }
        }
    }
