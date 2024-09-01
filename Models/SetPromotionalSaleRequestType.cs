    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetPromotionalSaleRequestType : AbstractRequestType
    {
        
        private ModifyActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private PromotionalSaleType promotionalSaleDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ModifyActionCodeType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalSaleType PromotionalSaleDetails
        {
            get
            {
                return this.promotionalSaleDetailsField;
            }
            set
            {
                this.promotionalSaleDetailsField = value;
            }
        }
    }
