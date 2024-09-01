    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BuyerRequirementDetailsType
    {
        
        private bool shipToRegistrationCountryField;
        
        private bool shipToRegistrationCountryFieldSpecified;
        
        private bool zeroFeedbackScoreField;
        
        private bool zeroFeedbackScoreFieldSpecified;
        
        private MaximumItemRequirementsType maximumItemRequirementsField;
        
        private MaximumUnpaidItemStrikesInfoType maximumUnpaidItemStrikesInfoField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShipToRegistrationCountry
        {
            get
            {
                return this.shipToRegistrationCountryField;
            }
            set
            {
                this.shipToRegistrationCountryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipToRegistrationCountrySpecified
        {
            get
            {
                return this.shipToRegistrationCountryFieldSpecified;
            }
            set
            {
                this.shipToRegistrationCountryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ZeroFeedbackScore
        {
            get
            {
                return this.zeroFeedbackScoreField;
            }
            set
            {
                this.zeroFeedbackScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZeroFeedbackScoreSpecified
        {
            get
            {
                return this.zeroFeedbackScoreFieldSpecified;
            }
            set
            {
                this.zeroFeedbackScoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MaximumItemRequirementsType MaximumItemRequirements
        {
            get
            {
                return this.maximumItemRequirementsField;
            }
            set
            {
                this.maximumItemRequirementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MaximumUnpaidItemStrikesInfoType MaximumUnpaidItemStrikesInfo
        {
            get
            {
                return this.maximumUnpaidItemStrikesInfoField;
            }
            set
            {
                this.maximumUnpaidItemStrikesInfoField = value;
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
