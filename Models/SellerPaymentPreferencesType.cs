    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerPaymentPreferencesType
    {
        
        private bool alwaysUseThisPaymentAddressField;
        
        private bool alwaysUseThisPaymentAddressFieldSpecified;
        
        private DisplayPayNowButtonCodeType displayPayNowButtonField;
        
        private bool displayPayNowButtonFieldSpecified;
        
        private bool payPalPreferredField;
        
        private bool payPalPreferredFieldSpecified;
        
        private string defaultPayPalEmailAddressField;
        
        private bool payPalAlwaysOnField;
        
        private bool payPalAlwaysOnFieldSpecified;
        
        private AddressType sellerPaymentAddressField;
        
        private UPSRateOptionCodeType uPSRateOptionField;
        
        private bool uPSRateOptionFieldSpecified;
        
        private FedExRateOptionCodeType fedExRateOptionField;
        
        private bool fedExRateOptionFieldSpecified;
        
        private USPSRateOptionCodeType uSPSRateOptionField;
        
        private bool uSPSRateOptionFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AlwaysUseThisPaymentAddress
        {
            get
            {
                return this.alwaysUseThisPaymentAddressField;
            }
            set
            {
                this.alwaysUseThisPaymentAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlwaysUseThisPaymentAddressSpecified
        {
            get
            {
                return this.alwaysUseThisPaymentAddressFieldSpecified;
            }
            set
            {
                this.alwaysUseThisPaymentAddressFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisplayPayNowButtonCodeType DisplayPayNowButton
        {
            get
            {
                return this.displayPayNowButtonField;
            }
            set
            {
                this.displayPayNowButtonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayPayNowButtonSpecified
        {
            get
            {
                return this.displayPayNowButtonFieldSpecified;
            }
            set
            {
                this.displayPayNowButtonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PayPalPreferred
        {
            get
            {
                return this.payPalPreferredField;
            }
            set
            {
                this.payPalPreferredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalPreferredSpecified
        {
            get
            {
                return this.payPalPreferredFieldSpecified;
            }
            set
            {
                this.payPalPreferredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DefaultPayPalEmailAddress
        {
            get
            {
                return this.defaultPayPalEmailAddressField;
            }
            set
            {
                this.defaultPayPalEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PayPalAlwaysOn
        {
            get
            {
                return this.payPalAlwaysOnField;
            }
            set
            {
                this.payPalAlwaysOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalAlwaysOnSpecified
        {
            get
            {
                return this.payPalAlwaysOnFieldSpecified;
            }
            set
            {
                this.payPalAlwaysOnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType SellerPaymentAddress
        {
            get
            {
                return this.sellerPaymentAddressField;
            }
            set
            {
                this.sellerPaymentAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UPSRateOptionCodeType UPSRateOption
        {
            get
            {
                return this.uPSRateOptionField;
            }
            set
            {
                this.uPSRateOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UPSRateOptionSpecified
        {
            get
            {
                return this.uPSRateOptionFieldSpecified;
            }
            set
            {
                this.uPSRateOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FedExRateOptionCodeType FedExRateOption
        {
            get
            {
                return this.fedExRateOptionField;
            }
            set
            {
                this.fedExRateOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FedExRateOptionSpecified
        {
            get
            {
                return this.fedExRateOptionFieldSpecified;
            }
            set
            {
                this.fedExRateOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public USPSRateOptionCodeType USPSRateOption
        {
            get
            {
                return this.uSPSRateOptionField;
            }
            set
            {
                this.uSPSRateOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool USPSRateOptionSpecified
        {
            get
            {
                return this.uSPSRateOptionFieldSpecified;
            }
            set
            {
                this.uSPSRateOptionFieldSpecified = value;
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
