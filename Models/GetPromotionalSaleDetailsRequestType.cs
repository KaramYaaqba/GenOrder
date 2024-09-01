    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetPromotionalSaleDetailsRequestType : AbstractRequestType
    {
        
        private long promotionalSaleIDField;
        
        private bool promotionalSaleIDFieldSpecified;
        
        private PromotionalSaleStatusCodeType[] promotionalSaleStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PromotionalSaleID
        {
            get
            {
                return this.promotionalSaleIDField;
            }
            set
            {
                this.promotionalSaleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleIDSpecified
        {
            get
            {
                return this.promotionalSaleIDFieldSpecified;
            }
            set
            {
                this.promotionalSaleIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalSaleStatus" )]
        public PromotionalSaleStatusCodeType[] PromotionalSaleStatus
        {
            get
            {
                return this.promotionalSaleStatusField;
            }
            set
            {
                this.promotionalSaleStatusField = value;
            }
        }
    }
