    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellereBayPaymentProcessConsentCodeType
    {
        
        private bool payoutMethodSetField;
        
        private bool payoutMethodSetFieldSpecified;
        
        private PayoutMethodType payoutMethodField;
        
        private bool payoutMethodFieldSpecified;
        
        private UserAgreementInfoType[] userAgreementInfoField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PayoutMethodSet
        {
            get
            {
                return this.payoutMethodSetField;
            }
            set
            {
                this.payoutMethodSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayoutMethodSetSpecified
        {
            get
            {
                return this.payoutMethodSetFieldSpecified;
            }
            set
            {
                this.payoutMethodSetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PayoutMethodType PayoutMethod
        {
            get
            {
                return this.payoutMethodField;
            }
            set
            {
                this.payoutMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayoutMethodSpecified
        {
            get
            {
                return this.payoutMethodFieldSpecified;
            }
            set
            {
                this.payoutMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAgreementInfo" )]
        public UserAgreementInfoType[] UserAgreementInfo
        {
            get
            {
                return this.userAgreementInfoField;
            }
            set
            {
                this.userAgreementInfoField = value;
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
