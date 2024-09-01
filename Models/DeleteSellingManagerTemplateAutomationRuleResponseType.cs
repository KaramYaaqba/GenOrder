    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerTemplateAutomationRuleResponseType : AbstractResponseType
    {
        
        private SellingManagerAutoListType automatedListingRuleField;
        
        private SellingManagerAutoRelistType automatedRelistingRuleField;
        
        private SellingManagerAutoSecondChanceOfferType automatedSecondChanceOfferRuleField;
        
        private FeeType[] feesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoListType AutomatedListingRule
        {
            get
            {
                return this.automatedListingRuleField;
            }
            set
            {
                this.automatedListingRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoRelistType AutomatedRelistingRule
        {
            get
            {
                return this.automatedRelistingRuleField;
            }
            set
            {
                this.automatedRelistingRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
        {
            get
            {
                return this.automatedSecondChanceOfferRuleField;
            }
            set
            {
                this.automatedSecondChanceOfferRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }
    }
