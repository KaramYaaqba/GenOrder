    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TransactionStatusType
    {
        
        private PaymentStatusCodeType eBayPaymentStatusField;
        
        private bool eBayPaymentStatusFieldSpecified;
        
        private CheckoutStatusCodeType checkoutStatusField;
        
        private bool checkoutStatusFieldSpecified;
        
        private System.DateTime lastTimeModifiedField;
        
        private bool lastTimeModifiedFieldSpecified;
        
        private BuyerPaymentMethodCodeType paymentMethodUsedField;
        
        private bool paymentMethodUsedFieldSpecified;
        
        private CompleteStatusCodeType completeStatusField;
        
        private bool completeStatusFieldSpecified;
        
        private bool buyerSelectedShippingField;
        
        private bool buyerSelectedShippingFieldSpecified;
        
        private PaymentHoldStatusCodeType paymentHoldStatusField;
        
        private bool paymentHoldStatusFieldSpecified;
        
        private bool integratedMerchantCreditCardEnabledField;
        
        private bool integratedMerchantCreditCardEnabledFieldSpecified;
        
        private eBayPaymentMismatchDetailsType eBayPaymentMismatchDetailsField;
        
        private InquiryStatusCodeType inquiryStatusField;
        
        private bool inquiryStatusFieldSpecified;
        
        private ReturnStatusCodeType returnStatusField;
        
        private bool returnStatusFieldSpecified;
        
        private BuyerPaymentInstrumentCodeType paymentInstrumentField;
        
        private bool paymentInstrumentFieldSpecified;
        
        private DigitalStatusCodeType digitalStatusField;
        
        private bool digitalStatusFieldSpecified;
        
        private CancelStatusCodeType cancelStatusField;
        
        private bool cancelStatusFieldSpecified;
        
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
        public CheckoutStatusCodeType CheckoutStatus
        {
            get
            {
                return this.checkoutStatusField;
            }
            set
            {
                this.checkoutStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckoutStatusSpecified
        {
            get
            {
                return this.checkoutStatusFieldSpecified;
            }
            set
            {
                this.checkoutStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastTimeModified
        {
            get
            {
                return this.lastTimeModifiedField;
            }
            set
            {
                this.lastTimeModifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastTimeModifiedSpecified
        {
            get
            {
                return this.lastTimeModifiedFieldSpecified;
            }
            set
            {
                this.lastTimeModifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerPaymentMethodCodeType PaymentMethodUsed
        {
            get
            {
                return this.paymentMethodUsedField;
            }
            set
            {
                this.paymentMethodUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentMethodUsedSpecified
        {
            get
            {
                return this.paymentMethodUsedFieldSpecified;
            }
            set
            {
                this.paymentMethodUsedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CompleteStatusCodeType CompleteStatus
        {
            get
            {
                return this.completeStatusField;
            }
            set
            {
                this.completeStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompleteStatusSpecified
        {
            get
            {
                return this.completeStatusFieldSpecified;
            }
            set
            {
                this.completeStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BuyerSelectedShipping
        {
            get
            {
                return this.buyerSelectedShippingField;
            }
            set
            {
                this.buyerSelectedShippingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyerSelectedShippingSpecified
        {
            get
            {
                return this.buyerSelectedShippingFieldSpecified;
            }
            set
            {
                this.buyerSelectedShippingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentHoldStatusCodeType PaymentHoldStatus
        {
            get
            {
                return this.paymentHoldStatusField;
            }
            set
            {
                this.paymentHoldStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentHoldStatusSpecified
        {
            get
            {
                return this.paymentHoldStatusFieldSpecified;
            }
            set
            {
                this.paymentHoldStatusFieldSpecified = value;
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
        public InquiryStatusCodeType InquiryStatus
        {
            get
            {
                return this.inquiryStatusField;
            }
            set
            {
                this.inquiryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InquiryStatusSpecified
        {
            get
            {
                return this.inquiryStatusFieldSpecified;
            }
            set
            {
                this.inquiryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ReturnStatusCodeType ReturnStatus
        {
            get
            {
                return this.returnStatusField;
            }
            set
            {
                this.returnStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnStatusSpecified
        {
            get
            {
                return this.returnStatusFieldSpecified;
            }
            set
            {
                this.returnStatusFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DigitalStatusCodeType DigitalStatus
        {
            get
            {
                return this.digitalStatusField;
            }
            set
            {
                this.digitalStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DigitalStatusSpecified
        {
            get
            {
                return this.digitalStatusFieldSpecified;
            }
            set
            {
                this.digitalStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CancelStatusCodeType CancelStatus
        {
            get
            {
                return this.cancelStatusField;
            }
            set
            {
                this.cancelStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelStatusSpecified
        {
            get
            {
                return this.cancelStatusFieldSpecified;
            }
            set
            {
                this.cancelStatusFieldSpecified = value;
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
