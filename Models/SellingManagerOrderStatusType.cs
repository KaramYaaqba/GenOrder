    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerOrderStatusType
    {
        
        private CheckoutStatusCodeType checkoutStatusField;
        
        private bool checkoutStatusFieldSpecified;
        
        private SellingManagerPaidStatusCodeType paidStatusField;
        
        private bool paidStatusFieldSpecified;
        
        private SellingManagerShippedStatusCodeType shippedStatusField;
        
        private bool shippedStatusFieldSpecified;
        
        private PaymentStatusCodeType eBayPaymentStatusField;
        
        private bool eBayPaymentStatusFieldSpecified;
        
        private string payPalTransactionIDField;
        
        private BuyerPaymentMethodCodeType paymentMethodUsedField;
        
        private bool paymentMethodUsedFieldSpecified;
        
        private CommentTypeCodeType feedbackReceivedField;
        
        private bool feedbackReceivedFieldSpecified;
        
        private bool feedbackSentField;
        
        private bool feedbackSentFieldSpecified;
        
        private int totalEmailsSentField;
        
        private bool totalEmailsSentFieldSpecified;
        
        private PaymentHoldStatusCodeType paymentHoldStatusField;
        
        private bool paymentHoldStatusFieldSpecified;
        
        private string sellerInvoiceNumberField;
        
        private System.DateTime shippedTimeField;
        
        private bool shippedTimeFieldSpecified;
        
        private System.DateTime paidTimeField;
        
        private bool paidTimeFieldSpecified;
        
        private System.DateTime lastEmailSentTimeField;
        
        private bool lastEmailSentTimeFieldSpecified;
        
        private System.DateTime sellerInvoiceTimeField;
        
        private bool sellerInvoiceTimeFieldSpecified;
        
        private bool integratedMerchantCreditCardEnabledField;
        
        private bool integratedMerchantCreditCardEnabledFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public SellingManagerPaidStatusCodeType PaidStatus
        {
            get
            {
                return this.paidStatusField;
            }
            set
            {
                this.paidStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaidStatusSpecified
        {
            get
            {
                return this.paidStatusFieldSpecified;
            }
            set
            {
                this.paidStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerShippedStatusCodeType ShippedStatus
        {
            get
            {
                return this.shippedStatusField;
            }
            set
            {
                this.shippedStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedStatusSpecified
        {
            get
            {
                return this.shippedStatusFieldSpecified;
            }
            set
            {
                this.shippedStatusFieldSpecified = value;
            }
        }
        
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
        public string PayPalTransactionID
        {
            get
            {
                return this.payPalTransactionIDField;
            }
            set
            {
                this.payPalTransactionIDField = value;
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
        public CommentTypeCodeType FeedbackReceived
        {
            get
            {
                return this.feedbackReceivedField;
            }
            set
            {
                this.feedbackReceivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackReceivedSpecified
        {
            get
            {
                return this.feedbackReceivedFieldSpecified;
            }
            set
            {
                this.feedbackReceivedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FeedbackSent
        {
            get
            {
                return this.feedbackSentField;
            }
            set
            {
                this.feedbackSentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackSentSpecified
        {
            get
            {
                return this.feedbackSentFieldSpecified;
            }
            set
            {
                this.feedbackSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalEmailsSent
        {
            get
            {
                return this.totalEmailsSentField;
            }
            set
            {
                this.totalEmailsSentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalEmailsSentSpecified
        {
            get
            {
                return this.totalEmailsSentFieldSpecified;
            }
            set
            {
                this.totalEmailsSentFieldSpecified = value;
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
        public string SellerInvoiceNumber
        {
            get
            {
                return this.sellerInvoiceNumberField;
            }
            set
            {
                this.sellerInvoiceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ShippedTime
        {
            get
            {
                return this.shippedTimeField;
            }
            set
            {
                this.shippedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedTimeSpecified
        {
            get
            {
                return this.shippedTimeFieldSpecified;
            }
            set
            {
                this.shippedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PaidTime
        {
            get
            {
                return this.paidTimeField;
            }
            set
            {
                this.paidTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaidTimeSpecified
        {
            get
            {
                return this.paidTimeFieldSpecified;
            }
            set
            {
                this.paidTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastEmailSentTime
        {
            get
            {
                return this.lastEmailSentTimeField;
            }
            set
            {
                this.lastEmailSentTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastEmailSentTimeSpecified
        {
            get
            {
                return this.lastEmailSentTimeFieldSpecified;
            }
            set
            {
                this.lastEmailSentTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime SellerInvoiceTime
        {
            get
            {
                return this.sellerInvoiceTimeField;
            }
            set
            {
                this.sellerInvoiceTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerInvoiceTimeSpecified
        {
            get
            {
                return this.sellerInvoiceTimeFieldSpecified;
            }
            set
            {
                this.sellerInvoiceTimeFieldSpecified = value;
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
