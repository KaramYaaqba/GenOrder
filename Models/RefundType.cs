    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RefundType
    {
        
        private AmountType refundFromSellerField;
        
        private AmountType totalRefundToBuyerField;
        
        private System.DateTime refundTimeField;
        
        private bool refundTimeFieldSpecified;
        
        private string refundIDField;
        
        private RefundTransactionArrayType refundTransactionArrayField;
        
        private AmountType refundAmountField;
        
        private RefundStatusCodeType refundStatusField;
        
        private bool refundStatusFieldSpecified;
        
        private RefundFailureReasonType refundFailureReasonField;
        
        private RefundFundingSourceArrayType refundFundingSourceArrayField;
        
        private string externalReferenceIDField;
        
        private System.DateTime refundRequestedTimeField;
        
        private bool refundRequestedTimeFieldSpecified;
        
        private System.DateTime refundCompletionTimeField;
        
        private bool refundCompletionTimeFieldSpecified;
        
        private System.DateTime estimatedRefundCompletionTimeField;
        
        private bool estimatedRefundCompletionTimeFieldSpecified;
        
        private string sellerNoteToBuyerField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType RefundFromSeller
        {
            get
            {
                return this.refundFromSellerField;
            }
            set
            {
                this.refundFromSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalRefundToBuyer
        {
            get
            {
                return this.totalRefundToBuyerField;
            }
            set
            {
                this.totalRefundToBuyerField = value;
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
        public string RefundID
        {
            get
            {
                return this.refundIDField;
            }
            set
            {
                this.refundIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RefundTransactionArrayType RefundTransactionArray
        {
            get
            {
                return this.refundTransactionArrayField;
            }
            set
            {
                this.refundTransactionArrayField = value;
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
        public RefundStatusCodeType RefundStatus
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
        public RefundFailureReasonType RefundFailureReason
        {
            get
            {
                return this.refundFailureReasonField;
            }
            set
            {
                this.refundFailureReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RefundFundingSourceArrayType RefundFundingSourceArray
        {
            get
            {
                return this.refundFundingSourceArrayField;
            }
            set
            {
                this.refundFundingSourceArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalReferenceID
        {
            get
            {
                return this.externalReferenceIDField;
            }
            set
            {
                this.externalReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RefundRequestedTime
        {
            get
            {
                return this.refundRequestedTimeField;
            }
            set
            {
                this.refundRequestedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundRequestedTimeSpecified
        {
            get
            {
                return this.refundRequestedTimeFieldSpecified;
            }
            set
            {
                this.refundRequestedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RefundCompletionTime
        {
            get
            {
                return this.refundCompletionTimeField;
            }
            set
            {
                this.refundCompletionTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundCompletionTimeSpecified
        {
            get
            {
                return this.refundCompletionTimeFieldSpecified;
            }
            set
            {
                this.refundCompletionTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EstimatedRefundCompletionTime
        {
            get
            {
                return this.estimatedRefundCompletionTimeField;
            }
            set
            {
                this.estimatedRefundCompletionTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimatedRefundCompletionTimeSpecified
        {
            get
            {
                return this.estimatedRefundCompletionTimeFieldSpecified;
            }
            set
            {
                this.estimatedRefundCompletionTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerNoteToBuyer
        {
            get
            {
                return this.sellerNoteToBuyerField;
            }
            set
            {
                this.sellerNoteToBuyerField = value;
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
