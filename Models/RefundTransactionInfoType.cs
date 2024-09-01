    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RefundTransactionInfoType
    {
        
        private PaymentTransactionStatusCodeType refundStatusField;
        
        private bool refundStatusFieldSpecified;
        
        private RefundSourceTypeCodeType refundTypeField;
        
        private bool refundTypeFieldSpecified;
        
        private UserIdentityType refundToField;
        
        private System.DateTime refundTimeField;
        
        private bool refundTimeFieldSpecified;
        
        private AmountType refundAmountField;
        
        private TransactionReferenceType referenceIDField;
        
        private AmountType feeOrCreditAmountField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentTransactionStatusCodeType RefundStatus
        {
            get
            {
                return this.refundStatusField;
            }
            set
            {
                this.refundStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundStatusSpecified
        {
            get
            {
                return this.refundStatusFieldSpecified;
            }
            set
            {
                this.refundStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RefundSourceTypeCodeType RefundType
        {
            get
            {
                return this.refundTypeField;
            }
            set
            {
                this.refundTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundTypeSpecified
        {
            get
            {
                return this.refundTypeFieldSpecified;
            }
            set
            {
                this.refundTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserIdentityType RefundTo
        {
            get
            {
                return this.refundToField;
            }
            set
            {
                this.refundToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RefundTime
        {
            get
            {
                return this.refundTimeField;
            }
            set
            {
                this.refundTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundTimeSpecified
        {
            get
            {
                return this.refundTimeFieldSpecified;
            }
            set
            {
                this.refundTimeFieldSpecified = value;
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
