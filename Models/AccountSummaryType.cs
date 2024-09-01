    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AccountSummaryType
    {
        
        private AccountStateCodeType accountStateField;
        
        private bool accountStateFieldSpecified;
        
        private AmountType invoicePaymentField;
        
        private AmountType invoiceCreditField;
        
        private AmountType invoiceNewFeeField;
        
        private AdditionalAccountType[] additionalAccountField;
        
        private AmountType amountPastDueField;
        
        private string bankAccountInfoField;
        
        private System.DateTime bankModifyDateField;
        
        private bool bankModifyDateFieldSpecified;
        
        private int billingCycleDateField;
        
        private bool billingCycleDateFieldSpecified;
        
        private System.DateTime creditCardExpirationField;
        
        private bool creditCardExpirationFieldSpecified;
        
        private string creditCardInfoField;
        
        private System.DateTime creditCardModifyDateField;
        
        private bool creditCardModifyDateFieldSpecified;
        
        private AmountType currentBalanceField;
        
        private string emailField;
        
        private AmountType invoiceBalanceField;
        
        private System.DateTime invoiceDateField;
        
        private bool invoiceDateFieldSpecified;
        
        private AmountType lastAmountPaidField;
        
        private System.DateTime lastPaymentDateField;
        
        private bool lastPaymentDateFieldSpecified;
        
        private bool pastDueField;
        
        private bool pastDueFieldSpecified;
        
        private SellerPaymentMethodCodeType paymentMethodField;
        
        private bool paymentMethodFieldSpecified;
        
        private NettedTransactionSummaryType nettedTransactionSummaryField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccountStateCodeType AccountState
        {
            get
            {
                return this.accountStateField;
            }
            set
            {
                this.accountStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountStateSpecified
        {
            get
            {
                return this.accountStateFieldSpecified;
            }
            set
            {
                this.accountStateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InvoicePayment
        {
            get
            {
                return this.invoicePaymentField;
            }
            set
            {
                this.invoicePaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InvoiceCredit
        {
            get
            {
                return this.invoiceCreditField;
            }
            set
            {
                this.invoiceCreditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InvoiceNewFee
        {
            get
            {
                return this.invoiceNewFeeField;
            }
            set
            {
                this.invoiceNewFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccount" )]
        public AdditionalAccountType[] AdditionalAccount
        {
            get
            {
                return this.additionalAccountField;
            }
            set
            {
                this.additionalAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType AmountPastDue
        {
            get
            {
                return this.amountPastDueField;
            }
            set
            {
                this.amountPastDueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BankAccountInfo
        {
            get
            {
                return this.bankAccountInfoField;
            }
            set
            {
                this.bankAccountInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime BankModifyDate
        {
            get
            {
                return this.bankModifyDateField;
            }
            set
            {
                this.bankModifyDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BankModifyDateSpecified
        {
            get
            {
                return this.bankModifyDateFieldSpecified;
            }
            set
            {
                this.bankModifyDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BillingCycleDate
        {
            get
            {
                return this.billingCycleDateField;
            }
            set
            {
                this.billingCycleDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillingCycleDateSpecified
        {
            get
            {
                return this.billingCycleDateFieldSpecified;
            }
            set
            {
                this.billingCycleDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreditCardExpiration
        {
            get
            {
                return this.creditCardExpirationField;
            }
            set
            {
                this.creditCardExpirationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditCardExpirationSpecified
        {
            get
            {
                return this.creditCardExpirationFieldSpecified;
            }
            set
            {
                this.creditCardExpirationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CreditCardInfo
        {
            get
            {
                return this.creditCardInfoField;
            }
            set
            {
                this.creditCardInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreditCardModifyDate
        {
            get
            {
                return this.creditCardModifyDateField;
            }
            set
            {
                this.creditCardModifyDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreditCardModifyDateSpecified
        {
            get
            {
                return this.creditCardModifyDateFieldSpecified;
            }
            set
            {
                this.creditCardModifyDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CurrentBalance
        {
            get
            {
                return this.currentBalanceField;
            }
            set
            {
                this.currentBalanceField = value;
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
        public AmountType InvoiceBalance
        {
            get
            {
                return this.invoiceBalanceField;
            }
            set
            {
                this.invoiceBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceDateSpecified
        {
            get
            {
                return this.invoiceDateFieldSpecified;
            }
            set
            {
                this.invoiceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType LastAmountPaid
        {
            get
            {
                return this.lastAmountPaidField;
            }
            set
            {
                this.lastAmountPaidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastPaymentDate
        {
            get
            {
                return this.lastPaymentDateField;
            }
            set
            {
                this.lastPaymentDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastPaymentDateSpecified
        {
            get
            {
                return this.lastPaymentDateFieldSpecified;
            }
            set
            {
                this.lastPaymentDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PastDue
        {
            get
            {
                return this.pastDueField;
            }
            set
            {
                this.pastDueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PastDueSpecified
        {
            get
            {
                return this.pastDueFieldSpecified;
            }
            set
            {
                this.pastDueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerPaymentMethodCodeType PaymentMethod
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
        public NettedTransactionSummaryType NettedTransactionSummary
        {
            get
            {
                return this.nettedTransactionSummaryField;
            }
            set
            {
                this.nettedTransactionSummaryField = value;
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
