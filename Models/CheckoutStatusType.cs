    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CheckoutStatusType
    {
        
        private PaymentStatusCodeType eBayPaymentStatusField;
        
        private bool eBayPaymentStatusFieldSpecified;
        
        private System.DateTime lastModifiedTimeField;
        
        private bool lastModifiedTimeFieldSpecified;
        
        private BuyerPaymentMethodCodeType paymentMethodField;
        
        private bool paymentMethodFieldSpecified;
        
        private CompleteStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private bool integratedMerchantCreditCardEnabledField;
        
        private bool integratedMerchantCreditCardEnabledFieldSpecified;
        
        private eBayPaymentMismatchDetailsType eBayPaymentMismatchDetailsField;
        
        private BuyerPaymentInstrumentCodeType paymentInstrumentField;
        
        private bool paymentInstrumentFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentStatusCodeType eBayPaymentStatus
        {
            get
            {
                return this.eBayPaymentStatusField;
            }
            set
            {
                this.eBayPaymentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eBayPaymentStatusSpecified
        {
            get
            {
                return this.eBayPaymentStatusFieldSpecified;
            }
            set
            {
                this.eBayPaymentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastModifiedTime
        {
            get
            {
                return this.lastModifiedTimeField;
            }
            set
            {
                this.lastModifiedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedTimeSpecified
        {
            get
            {
                return this.lastModifiedTimeFieldSpecified;
            }
            set
            {
                this.lastModifiedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerPaymentMethodCodeType PaymentMethod
        {
            get
            {
                return this.paymentMethodField;
            }
            set
            {
                this.paymentMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentMethodSpecified
        {
            get
            {
                return this.paymentMethodFieldSpecified;
            }
            set
            {
                this.paymentMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CompleteStatusCodeType Status
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
        public bool IntegratedMerchantCreditCardEnabled
        {
            get
            {
                return this.integratedMerchantCreditCardEnabledField;
            }
            set
            {
                this.integratedMerchantCreditCardEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntegratedMerchantCreditCardEnabledSpecified
        {
            get
            {
                return this.integratedMerchantCreditCardEnabledFieldSpecified;
            }
            set
            {
                this.integratedMerchantCreditCardEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public eBayPaymentMismatchDetailsType eBayPaymentMismatchDetails
        {
            get
            {
                return this.eBayPaymentMismatchDetailsField;
            }
            set
            {
                this.eBayPaymentMismatchDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerPaymentInstrumentCodeType PaymentInstrument
        {
            get
            {
                return this.paymentInstrumentField;
            }
            set
            {
                this.paymentInstrumentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentInstrumentSpecified
        {
            get
            {
                return this.paymentInstrumentFieldSpecified;
            }
            set
            {
                this.paymentInstrumentFieldSpecified = value;
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
