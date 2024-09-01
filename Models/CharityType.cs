    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CharityType
    {
        
        private string charityNameField;
        
        private int charityNumberField;
        
        private bool charityNumberFieldSpecified;
        
        private float donationPercentField;
        
        private bool donationPercentFieldSpecified;
        
        private string charityIDField;
        
        private string missionField;
        
        private string logoURLField;
        
        private CharityStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private bool charityListingField;
        
        private bool charityListingFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CharityName
        {
            get
            {
                return this.charityNameField;
            }
            set
            {
                this.charityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CharityNumber
        {
            get
            {
                return this.charityNumberField;
            }
            set
            {
                this.charityNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityNumberSpecified
        {
            get
            {
                return this.charityNumberFieldSpecified;
            }
            set
            {
                this.charityNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float DonationPercent
        {
            get
            {
                return this.donationPercentField;
            }
            set
            {
                this.donationPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DonationPercentSpecified
        {
            get
            {
                return this.donationPercentFieldSpecified;
            }
            set
            {
                this.donationPercentFieldSpecified = value;
            }
        }
        
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
        public string Mission
        {
            get
            {
                return this.missionField;
            }
            set
            {
                this.missionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string LogoURL
        {
            get
            {
                return this.logoURLField;
            }
            set
            {
                this.logoURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CharityStatusCodeType Status
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
        public bool CharityListing
        {
            get
            {
                return this.charityListingField;
            }
            set
            {
                this.charityListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityListingSpecified
        {
            get
            {
                return this.charityListingFieldSpecified;
            }
            set
            {
                this.charityListingFieldSpecified = value;
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
