    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerTemplateAutomationRuleRequestType : AbstractRequestType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private bool deleteAutomatedListingRuleField;
        
        private bool deleteAutomatedListingRuleFieldSpecified;
        
        private bool deleteAutomatedRelistingRuleField;
        
        private bool deleteAutomatedRelistingRuleFieldSpecified;
        
        private bool deleteAutomatedSecondChanceOfferRuleField;
        
        private bool deleteAutomatedSecondChanceOfferRuleFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleTemplateID
        {
            get
            {
                return this.saleTemplateIDField;
            }
            set
            {
                this.saleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleTemplateIDSpecified
        {
            get
            {
                return this.saleTemplateIDFieldSpecified;
            }
            set
            {
                this.saleTemplateIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DeleteAutomatedListingRule
        {
            get
            {
                return this.deleteAutomatedListingRuleField;
            }
            set
            {
                this.deleteAutomatedListingRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteAutomatedListingRuleSpecified
        {
            get
            {
                return this.deleteAutomatedListingRuleFieldSpecified;
            }
            set
            {
                this.deleteAutomatedListingRuleFieldSpecified = value;
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
