    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MembershipDetailType
    {
        
        private string programNameField;
        
        private SiteCodeType siteField;
        
        private bool siteFieldSpecified;
        
        private System.DateTime expiryDateField;
        
        private bool expiryDateFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProgramName
        {
            get
            {
                return this.programNameField;
            }
            set
            {
                this.programNameField = value;
            }
        }
        
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
        public System.DateTime ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiryDateSpecified
        {
            get
            {
                return this.expiryDateFieldSpecified;
            }
            set
            {
                this.expiryDateFieldSpecified = value;
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
