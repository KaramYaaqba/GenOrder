    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UserAgreementInfoType
    {
        
        private SiteCodeType siteField;
        
        private bool siteFieldSpecified;
        
        private SellereBayPaymentProcessStatusCodeType sellereBayPaymentProcessStatusField;
        
        private bool sellereBayPaymentProcessStatusFieldSpecified;
        
        private System.DateTime acceptedTimeField;
        
        private bool acceptedTimeFieldSpecified;
        
        private System.DateTime sellereBayPaymentProcessEnableTimeField;
        
        private bool sellereBayPaymentProcessEnableTimeFieldSpecified;
        
        private string userAgreementURLField;
        
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
        public SellereBayPaymentProcessStatusCodeType SellereBayPaymentProcessStatus
        {
            get
            {
                return this.sellereBayPaymentProcessStatusField;
            }
            set
            {
                this.sellereBayPaymentProcessStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellereBayPaymentProcessStatusSpecified
        {
            get
            {
                return this.sellereBayPaymentProcessStatusFieldSpecified;
            }
            set
            {
                this.sellereBayPaymentProcessStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime AcceptedTime
        {
            get
            {
                return this.acceptedTimeField;
            }
            set
            {
                this.acceptedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptedTimeSpecified
        {
            get
            {
                return this.acceptedTimeFieldSpecified;
            }
            set
            {
                this.acceptedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime SellereBayPaymentProcessEnableTime
        {
            get
            {
                return this.sellereBayPaymentProcessEnableTimeField;
            }
            set
            {
                this.sellereBayPaymentProcessEnableTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellereBayPaymentProcessEnableTimeSpecified
        {
            get
            {
                return this.sellereBayPaymentProcessEnableTimeFieldSpecified;
            }
            set
            {
                this.sellereBayPaymentProcessEnableTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string UserAgreementURL
        {
            get
            {
                return this.userAgreementURLField;
            }
            set
            {
                this.userAgreementURLField = value;
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
