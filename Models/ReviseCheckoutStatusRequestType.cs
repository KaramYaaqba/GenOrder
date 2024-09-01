    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseCheckoutStatusRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string transactionIDField;
        
        private string orderIDField;
        
        private AmountType amountPaidField;
        
        private BuyerPaymentMethodCodeType paymentMethodUsedField;
        
        private bool paymentMethodUsedFieldSpecified;
        
        private CompleteStatusCodeType checkoutStatusField;
        
        private bool checkoutStatusFieldSpecified;
        
        private string shippingServiceField;
        
        private bool shippingIncludedInTaxField;
        
        private bool shippingIncludedInTaxFieldSpecified;
        
        private CheckoutMethodCodeType checkoutMethodField;
        
        private bool checkoutMethodFieldSpecified;
        
        private InsuranceSelectedCodeType insuranceTypeField;
        
        private bool insuranceTypeFieldSpecified;
        
        private RCSPaymentStatusCodeType paymentStatusField;
        
        private bool paymentStatusFieldSpecified;
        
        private AmountType adjustmentAmountField;
        
        private AddressType shippingAddressField;
        
        private string buyerIDField;
        
        private AmountType shippingInsuranceCostField;
        
        private AmountType salesTaxField;
        
        private AmountType shippingCostField;
        
        private string encryptedIDField;
        
        private ExternalTransactionType externalTransactionField;
        
        private string multipleSellerPaymentIDField;
        
        private AmountType cODCostField;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType AmountPaid
        {
            get
            {
                return this.amountPaidField;
            }
            set
            {
                this.amountPaidField = value;
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
        public CompleteStatusCodeType CheckoutStatus
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingService
        {
            get
            {
                return this.shippingServiceField;
            }
            set
            {
                this.shippingServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShippingIncludedInTax
        {
            get
            {
                return this.shippingIncludedInTaxField;
            }
            set
            {
                this.shippingIncludedInTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingIncludedInTaxSpecified
        {
            get
            {
                return this.shippingIncludedInTaxFieldSpecified;
            }
            set
            {
                this.shippingIncludedInTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CheckoutMethodCodeType CheckoutMethod
        {
            get
            {
                return this.checkoutMethodField;
            }
            set
            {
                this.checkoutMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckoutMethodSpecified
        {
            get
            {
                return this.checkoutMethodFieldSpecified;
            }
            set
            {
                this.checkoutMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public InsuranceSelectedCodeType InsuranceType
        {
            get
            {
                return this.insuranceTypeField;
            }
            set
            {
                this.insuranceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InsuranceTypeSpecified
        {
            get
            {
                return this.insuranceTypeFieldSpecified;
            }
            set
            {
                this.insuranceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RCSPaymentStatusCodeType PaymentStatus
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
        public AmountType AdjustmentAmount
        {
            get
            {
                return this.adjustmentAmountField;
            }
            set
            {
                this.adjustmentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerID
        {
            get
            {
                return this.buyerIDField;
            }
            set
            {
                this.buyerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingInsuranceCost
        {
            get
            {
                return this.shippingInsuranceCostField;
            }
            set
            {
                this.shippingInsuranceCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType SalesTax
        {
            get
            {
                return this.salesTaxField;
            }
            set
            {
                this.salesTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingCost
        {
            get
            {
                return this.shippingCostField;
            }
            set
            {
                this.shippingCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EncryptedID
        {
            get
            {
                return this.encryptedIDField;
            }
            set
            {
                this.encryptedIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ExternalTransactionType ExternalTransaction
        {
            get
            {
                return this.externalTransactionField;
            }
            set
            {
                this.externalTransactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MultipleSellerPaymentID
        {
            get
            {
                return this.multipleSellerPaymentIDField;
            }
            set
            {
                this.multipleSellerPaymentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CODCost
        {
            get
            {
                return this.cODCostField;
            }
            set
            {
                this.cODCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderLineItemID
        {
            get
            {
                return this.orderLineItemIDField;
            }
            set
            {
                this.orderLineItemIDField = value;
            }
        }
    }
