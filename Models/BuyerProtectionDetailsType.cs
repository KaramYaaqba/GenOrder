    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BuyerProtectionDetailsType
    {
        
        private BuyerProtectionSourceCodeType buyerProtectionSourceField;
        
        private bool buyerProtectionSourceFieldSpecified;
        
        private BuyerProtectionCodeType buyerProtectionStatusField;
        
        private bool buyerProtectionStatusFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerProtectionSourceCodeType BuyerProtectionSource
        {
            get
            {
                return this.buyerProtectionSourceField;
            }
            set
            {
                this.buyerProtectionSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyerProtectionSourceSpecified
        {
            get
            {
                return this.buyerProtectionSourceFieldSpecified;
            }
            set
            {
                this.buyerProtectionSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerProtectionCodeType BuyerProtectionStatus
        {
            get
            {
                return this.buyerProtectionStatusField;
            }
            set
            {
                this.buyerProtectionStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyerProtectionStatusSpecified
        {
            get
            {
                return this.buyerProtectionStatusFieldSpecified;
            }
            set
            {
                this.buyerProtectionStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
