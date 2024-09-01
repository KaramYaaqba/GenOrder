    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetSellingManagerTemplateAutomationRuleRequestType : AbstractRequestType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private SellingManagerAutoListType automatedListingRuleField;
        
        private SellingManagerAutoRelistType automatedRelistingRuleField;
        
        private SellingManagerAutoSecondChanceOfferType automatedSecondChanceOfferRuleField;
        
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
    }
