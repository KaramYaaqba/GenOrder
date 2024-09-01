    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ExternalTransactionType
    {
        
        private string externalTransactionIDField;
        
        private System.DateTime externalTransactionTimeField;
        
        private bool externalTransactionTimeFieldSpecified;
        
        private AmountType feeOrCreditAmountField;
        
        private AmountType paymentOrRefundAmountField;
        
        private PaymentTransactionStatusCodeType externalTransactionStatusField;
        
        private bool externalTransactionStatusFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalTransactionID
        {
            get
            {
                return this.externalTransactionIDField;
            }
            set
            {
                this.externalTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ExternalTransactionTime
        {
            get
            {
                return this.externalTransactionTimeField;
            }
            set
            {
                this.externalTransactionTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalTransactionTimeSpecified
        {
            get
            {
                return this.externalTransactionTimeFieldSpecified;
            }
            set
            {
                this.externalTransactionTimeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PaymentOrRefundAmount
        {
            get
            {
                return this.paymentOrRefundAmountField;
            }
            set
            {
                this.paymentOrRefundAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentTransactionStatusCodeType ExternalTransactionStatus
        {
            get
            {
                return this.externalTransactionStatusField;
            }
            set
            {
                this.externalTransactionStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalTransactionStatusSpecified
        {
            get
            {
                return this.externalTransactionStatusFieldSpecified;
            }
            set
            {
                this.externalTransactionStatusFieldSpecified = value;
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
