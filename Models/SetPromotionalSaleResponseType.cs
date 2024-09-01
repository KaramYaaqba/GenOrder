    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetPromotionalSaleResponseType : AbstractResponseType
    {
        
        private PromotionalSaleStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private long promotionalSaleIDField;
        
        private bool promotionalSaleIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalSaleStatusCodeType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
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
    }
