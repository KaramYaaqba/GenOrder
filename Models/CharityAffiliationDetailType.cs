    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CharityAffiliationDetailType
    {
        
        private string charityIDField;
        
        private CharityAffiliationTypeCodeType affiliationTypeField;
        
        private bool affiliationTypeFieldSpecified;
        
        private System.DateTime lastUsedTimeField;
        
        private bool lastUsedTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CharityID
        {
            get
            {
                return this.charityIDField;
            }
            set
            {
                this.charityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CharityAffiliationTypeCodeType AffiliationType
        {
            get
            {
                return this.affiliationTypeField;
            }
            set
            {
                this.affiliationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AffiliationTypeSpecified
        {
            get
            {
                return this.affiliationTypeFieldSpecified;
            }
            set
            {
                this.affiliationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastUsedTime
        {
            get
            {
                return this.lastUsedTimeField;
            }
            set
            {
                this.lastUsedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUsedTimeSpecified
        {
            get
            {
                return this.lastUsedTimeFieldSpecified;
            }
            set
            {
                this.lastUsedTimeFieldSpecified = value;
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
