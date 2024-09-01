    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VATDetailsType
    {
        
        private bool businessSellerField;
        
        private bool businessSellerFieldSpecified;
        
        private bool restrictedToBusinessField;
        
        private bool restrictedToBusinessFieldSpecified;
        
        private float vATPercentField;
        
        private bool vATPercentFieldSpecified;
        
        private string vATSiteField;
        
        private string vATIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BusinessSeller
        {
            get
            {
                return this.businessSellerField;
            }
            set
            {
                this.businessSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BusinessSellerSpecified
        {
            get
            {
                return this.businessSellerFieldSpecified;
            }
            set
            {
                this.businessSellerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool RestrictedToBusiness
        {
            get
            {
                return this.restrictedToBusinessField;
            }
            set
            {
                this.restrictedToBusinessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictedToBusinessSpecified
        {
            get
            {
                return this.restrictedToBusinessFieldSpecified;
            }
            set
            {
                this.restrictedToBusinessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float VATPercent
        {
            get
            {
                return this.vATPercentField;
            }
            set
            {
                this.vATPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATPercentSpecified
        {
            get
            {
                return this.vATPercentFieldSpecified;
            }
            set
            {
                this.vATPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VATSite
        {
            get
            {
                return this.vATSiteField;
            }
            set
            {
                this.vATSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VATID
        {
            get
            {
                return this.vATIDField;
            }
            set
            {
                this.vATIDField = value;
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
