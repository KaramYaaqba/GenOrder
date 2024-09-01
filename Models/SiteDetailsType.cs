    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SiteDetailsType
    {
        
        private SiteCodeType siteField;
        
        private bool siteFieldSpecified;
        
        private int siteIDField;
        
        private bool siteIDFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SiteCodeType Site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteSpecified
        {
            get
            {
                return this.siteFieldSpecified;
            }
            set
            {
                this.siteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int SiteID
        {
            get
            {
                return this.siteIDField;
            }
            set
            {
                this.siteIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteIDSpecified
        {
            get
            {
                return this.siteIDFieldSpecified;
            }
            set
            {
                this.siteIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
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
