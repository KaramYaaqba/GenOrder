    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RefundFundingSourceType
    {
        
        private RefundingSourceTypeCodeType refundingSourceTypeField;
        
        private bool refundingSourceTypeFieldSpecified;
        
        private string accountNumberField;
        
        private AmountType refundAmountField;
        
        private string sellerExternalTransactionIDField;
        
        private string buyerExternalTransactionIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RefundingSourceTypeCodeType RefundingSourceType
        {
            get
            {
                return this.refundingSourceTypeField;
            }
            set
            {
                this.refundingSourceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundingSourceTypeSpecified
        {
            get
            {
                return this.refundingSourceTypeFieldSpecified;
            }
            set
            {
                this.refundingSourceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AccountNumber
        {
            get
            {
                return this.accountNumberField;
            }
            set
            {
                this.accountNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType RefundAmount
        {
            get
            {
                return this.refundAmountField;
            }
            set
            {
                this.refundAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerExternalTransactionID
        {
            get
            {
                return this.sellerExternalTransactionIDField;
            }
            set
            {
                this.sellerExternalTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerExternalTransactionID
        {
            get
            {
                return this.buyerExternalTransactionIDField;
            }
            set
            {
                this.buyerExternalTransactionIDField = value;
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
