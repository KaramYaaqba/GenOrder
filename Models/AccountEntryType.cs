    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AccountEntryType
    {
        
        private AccountDetailEntryCodeType accountDetailsEntryTypeField;
        
        private bool accountDetailsEntryTypeFieldSpecified;
        
        private string descriptionField;
        
        private AmountType balanceField;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private AmountType grossDetailAmountField;
        
        private string itemIDField;
        
        private string memoField;
        
        private AmountType conversionRateField;
        
        private AmountType netDetailAmountField;
        
        private string refNumberField;
        
        private decimal vATPercentField;
        
        private bool vATPercentFieldSpecified;
        
        private string titleField;
        
        private string orderLineItemIDField;
        
        private string transactionIDField;
        
        private bool receivedTopRatedDiscountField;
        
        private bool receivedTopRatedDiscountFieldSpecified;
        
        private string orderIdField;
        
        private DiscountType[] discountDetailField;
        
        private bool nettedField;
        
        private bool nettedFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccountDetailEntryCodeType AccountDetailsEntryType
        {
            get
            {
                return this.accountDetailsEntryTypeField;
            }
            set
            {
                this.accountDetailsEntryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountDetailsEntryTypeSpecified
        {
            get
            {
                return this.accountDetailsEntryTypeFieldSpecified;
            }
            set
            {
                this.accountDetailsEntryTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Balance
        {
            get
            {
                return this.balanceField;
            }
            set
            {
                this.balanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType GrossDetailAmount
        {
            get
            {
                return this.grossDetailAmountField;
            }
            set
            {
                this.grossDetailAmountField = value;
            }
        }
        
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
        public string Memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConversionRate
        {
            get
            {
                return this.conversionRateField;
            }
            set
            {
                this.conversionRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType NetDetailAmount
        {
            get
            {
                return this.netDetailAmountField;
            }
            set
            {
                this.netDetailAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public decimal VATPercent
        {
            get
            {
                return this.vATPercentField;
            }
            set
            {
                this.vATPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATPercentSpecified
        {
            get
            {
                return this.vATPercentFieldSpecified;
            }
            set
            {
                this.vATPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
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
        public bool ReceivedTopRatedDiscount
        {
            get
            {
                return this.receivedTopRatedDiscountField;
            }
            set
            {
                this.receivedTopRatedDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceivedTopRatedDiscountSpecified
        {
            get
            {
                return this.receivedTopRatedDiscountFieldSpecified;
            }
            set
            {
                this.receivedTopRatedDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Discount", IsNullable=false)]
        public DiscountType[] DiscountDetail
        {
            get
            {
                return this.discountDetailField;
            }
            set
            {
                this.discountDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Netted
        {
            get
            {
                return this.nettedField;
            }
            set
            {
                this.nettedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NettedSpecified
        {
            get
            {
                return this.nettedFieldSpecified;
            }
            set
            {
                this.nettedFieldSpecified = value;
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
