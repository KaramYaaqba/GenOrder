    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RecoupmentPolicyDetailsType
    {
        
        private bool enforcedOnListingSiteField;
        
        private bool enforcedOnListingSiteFieldSpecified;
        
        private bool enforcedOnRegistrationSiteField;
        
        private bool enforcedOnRegistrationSiteFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EnforcedOnListingSite
        {
            get
            {
                return this.enforcedOnListingSiteField;
            }
            set
            {
                this.enforcedOnListingSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnforcedOnListingSiteSpecified
        {
            get
            {
                return this.enforcedOnListingSiteFieldSpecified;
            }
            set
            {
                this.enforcedOnListingSiteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EnforcedOnRegistrationSite
        {
            get
            {
                return this.enforcedOnRegistrationSiteField;
            }
            set
            {
                this.enforcedOnRegistrationSiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnforcedOnRegistrationSiteSpecified
        {
            get
            {
                return this.enforcedOnRegistrationSiteFieldSpecified;
            }
            set
            {
                this.enforcedOnRegistrationSiteFieldSpecified = value;
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
