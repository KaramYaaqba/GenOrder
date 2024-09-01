    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SendInvoiceRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string transactionIDField;
        
        private string orderIDField;
        
        private InternationalShippingServiceOptionsType[] internationalShippingServiceOptionsField;
        
        private ShippingServiceOptionsType[] shippingServiceOptionsField;
        
        private SalesTaxType salesTaxField;
        
        private InsuranceOptionCodeType insuranceOptionField;
        
        private bool insuranceOptionFieldSpecified;
        
        private AmountType insuranceFeeField;
        
        private BuyerPaymentMethodCodeType[] paymentMethodsField;
        
        private string payPalEmailAddressField;
        
        private string checkoutInstructionsField;
        
        private bool emailCopyToSellerField;
        
        private bool emailCopyToSellerFieldSpecified;
        
        private AmountType cODCostField;
        
        private string sKUField;
        
        private string orderLineItemIDField;
        
        private AmountType adjustmentAmountField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("InternationalShippingServiceOptions" )]
        public InternationalShippingServiceOptionsType[] InternationalShippingServiceOptions
        {
            get
            {
                return this.internationalShippingServiceOptionsField;
            }
            set
            {
                this.internationalShippingServiceOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingServiceOptions" )]
        public ShippingServiceOptionsType[] ShippingServiceOptions
        {
            get
            {
                return this.shippingServiceOptionsField;
            }
            set
            {
                this.shippingServiceOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SalesTaxType SalesTax
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
        public InsuranceOptionCodeType InsuranceOption
        {
            get
            {
                return this.insuranceOptionField;
            }
            set
            {
                this.insuranceOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InsuranceOptionSpecified
        {
            get
            {
                return this.insuranceOptionFieldSpecified;
            }
            set
            {
                this.insuranceOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InsuranceFee
        {
            get
            {
                return this.insuranceFeeField;
            }
            set
            {
                this.insuranceFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMethods" )]
        public BuyerPaymentMethodCodeType[] PaymentMethods
        {
            get
            {
                return this.paymentMethodsField;
            }
            set
            {
                this.paymentMethodsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PayPalEmailAddress
        {
            get
            {
                return this.payPalEmailAddressField;
            }
            set
            {
                this.payPalEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CheckoutInstructions
        {
            get
            {
                return this.checkoutInstructionsField;
            }
            set
            {
                this.checkoutInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EmailCopyToSeller
        {
            get
            {
                return this.emailCopyToSellerField;
            }
            set
            {
                this.emailCopyToSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailCopyToSellerSpecified
        {
            get
            {
                return this.emailCopyToSellerFieldSpecified;
            }
            set
            {
                this.emailCopyToSellerFieldSpecified = value;
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
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
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
    }
