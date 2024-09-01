    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SiteBuyerRequirementDetailsType
    {
        
        private bool linkedPayPalAccountField;
        
        private bool linkedPayPalAccountFieldSpecified;
        
        private MaximumBuyerPolicyViolationsDetailsType maximumBuyerPolicyViolationsField;
        
        private MaximumItemRequirementsDetailsType maximumItemRequirementsField;
        
        private MaximumUnpaidItemStrikesInfoDetailsType maximumUnpaidItemStrikesInfoField;
        
        private MinimumFeedbackScoreDetailsType minimumFeedbackScoreField;
        
        private bool shipToRegistrationCountryField;
        
        private bool shipToRegistrationCountryFieldSpecified;
        
        private VerifiedUserRequirementsDetailsType verifiedUserRequirementsField;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool LinkedPayPalAccount
        {
            get
            {
                return this.linkedPayPalAccountField;
            }
            set
            {
                this.linkedPayPalAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkedPayPalAccountSpecified
        {
            get
            {
                return this.linkedPayPalAccountFieldSpecified;
            }
            set
            {
                this.linkedPayPalAccountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MaximumBuyerPolicyViolationsDetailsType MaximumBuyerPolicyViolations
        {
            get
            {
                return this.maximumBuyerPolicyViolationsField;
            }
            set
            {
                this.maximumBuyerPolicyViolationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MaximumItemRequirementsDetailsType MaximumItemRequirements
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
        public MaximumUnpaidItemStrikesInfoDetailsType MaximumUnpaidItemStrikesInfo
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MinimumFeedbackScoreDetailsType MinimumFeedbackScore
        {
            get
            {
                return this.minimumFeedbackScoreField;
            }
            set
            {
                this.minimumFeedbackScoreField = value;
            }
        }
        
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
        public VerifiedUserRequirementsDetailsType VerifiedUserRequirements
        {
            get
            {
                return this.verifiedUserRequirementsField;
            }
            set
            {
                this.verifiedUserRequirementsField = value;
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
