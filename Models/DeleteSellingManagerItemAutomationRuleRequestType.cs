    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerItemAutomationRuleRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private bool deleteAutomatedRelistingRuleField;
        
        private bool deleteAutomatedRelistingRuleFieldSpecified;
        
        private bool deleteAutomatedSecondChanceOfferRuleField;
        
        private bool deleteAutomatedSecondChanceOfferRuleFieldSpecified;
        
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
        public bool DeleteAutomatedRelistingRule
        {
            get
            {
                return this.deleteAutomatedRelistingRuleField;
            }
            set
            {
                this.deleteAutomatedRelistingRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteAutomatedRelistingRuleSpecified
        {
            get
            {
                return this.deleteAutomatedRelistingRuleFieldSpecified;
            }
            set
            {
                this.deleteAutomatedRelistingRuleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DeleteAutomatedSecondChanceOfferRule
        {
            get
            {
                return this.deleteAutomatedSecondChanceOfferRuleField;
            }
            set
            {
                this.deleteAutomatedSecondChanceOfferRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteAutomatedSecondChanceOfferRuleSpecified
        {
            get
            {
                return this.deleteAutomatedSecondChanceOfferRuleFieldSpecified;
            }
            set
            {
                this.deleteAutomatedSecondChanceOfferRuleFieldSpecified = value;
            }
        }
    }
