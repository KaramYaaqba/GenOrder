    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetSellingManagerItemAutomationRuleRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private SellingManagerAutoRelistType automatedRelistingRuleField;
        
        private SellingManagerAutoSecondChanceOfferType automatedSecondChanceOfferRuleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
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
    }
