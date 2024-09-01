    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class eBayPLUSPreferenceType
    {
        
        private CountryCodeType countryField;
        
        private bool countryFieldSpecified;
        
        private bool optInStatusField;
        
        private bool optInStatusFieldSpecified;
        
        private bool listingPreferenceField;
        
        private bool listingPreferenceFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountrySpecified
        {
            get
            {
                return this.countryFieldSpecified;
            }
            set
            {
                this.countryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool OptInStatus
        {
            get
            {
                return this.optInStatusField;
            }
            set
            {
                this.optInStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptInStatusSpecified
        {
            get
            {
                return this.optInStatusFieldSpecified;
            }
            set
            {
                this.optInStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ListingPreference
        {
            get
            {
                return this.listingPreferenceField;
            }
            set
            {
                this.listingPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingPreferenceSpecified
        {
            get
            {
                return this.listingPreferenceFieldSpecified;
            }
            set
            {
                this.listingPreferenceFieldSpecified = value;
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
