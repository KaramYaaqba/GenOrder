    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BusinessSellerDetailsType
    {
        
        private AddressType addressField;
        
        private string faxField;
        
        private string emailField;
        
        private string additionalContactInformationField;
        
        private string tradeRegistrationNumberField;
        
        private bool legalInvoiceField;
        
        private bool legalInvoiceFieldSpecified;
        
        private string termsAndConditionsField;
        
        private VATDetailsType vATDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AdditionalContactInformation
        {
            get
            {
                return this.additionalContactInformationField;
            }
            set
            {
                this.additionalContactInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TradeRegistrationNumber
        {
            get
            {
                return this.tradeRegistrationNumberField;
            }
            set
            {
                this.tradeRegistrationNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool LegalInvoice
        {
            get
            {
                return this.legalInvoiceField;
            }
            set
            {
                this.legalInvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LegalInvoiceSpecified
        {
            get
            {
                return this.legalInvoiceFieldSpecified;
            }
            set
            {
                this.legalInvoiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TermsAndConditions
        {
            get
            {
                return this.termsAndConditionsField;
            }
            set
            {
                this.termsAndConditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VATDetailsType VATDetails
        {
            get
            {
                return this.vATDetailsField;
            }
            set
            {
                this.vATDetailsField = value;
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
