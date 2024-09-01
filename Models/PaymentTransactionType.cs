    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PaymentTransactionType
    {
        
        private PaymentTransactionStatusCodeType paymentStatusField;
        
        private bool paymentStatusFieldSpecified;
        
        private UserIdentityType payerField;
        
        private UserIdentityType payeeField;
        
        private System.DateTime paymentTimeField;
        
        private bool paymentTimeFieldSpecified;
        
        private AmountType paymentAmountField;
        
        private TransactionReferenceType referenceIDField;
        
        private AmountType feeOrCreditAmountField;
        
        private TransactionReferenceType[] paymentReferenceIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentTransactionStatusCodeType PaymentStatus
        {
            get
            {
                return this.paymentStatusField;
            }
            set
            {
                this.paymentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentStatusSpecified
        {
            get
            {
                return this.paymentStatusFieldSpecified;
            }
            set
            {
                this.paymentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserIdentityType Payer
        {
            get
            {
                return this.payerField;
            }
            set
            {
                this.payerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserIdentityType Payee
        {
            get
            {
                return this.payeeField;
            }
            set
            {
                this.payeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PaymentTime
        {
            get
            {
                return this.paymentTimeField;
            }
            set
            {
                this.paymentTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentTimeSpecified
        {
            get
            {
                return this.paymentTimeFieldSpecified;
            }
            set
            {
                this.paymentTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PaymentAmount
        {
            get
            {
                return this.paymentAmountField;
            }
            set
            {
                this.paymentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionReferenceType ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType FeeOrCreditAmount
        {
            get
            {
                return this.feeOrCreditAmountField;
            }
            set
            {
                this.feeOrCreditAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentReferenceID" )]
        public TransactionReferenceType[] PaymentReferenceID
        {
            get
            {
                return this.paymentReferenceIDField;
            }
            set
            {
                this.paymentReferenceIDField = value;
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
