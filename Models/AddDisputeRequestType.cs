    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddDisputeRequestType : AbstractRequestType
    {
        
        private DisputeExplanationCodeType disputeExplanationField;
        
        private bool disputeExplanationFieldSpecified;
        
        private DisputeReasonCodeType disputeReasonField;
        
        private bool disputeReasonFieldSpecified;
        
        private string itemIDField;
        
        private string transactionIDField;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeExplanationCodeType DisputeExplanation
        {
            get
            {
                return this.disputeExplanationField;
            }
            set
            {
                this.disputeExplanationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeExplanationSpecified
        {
            get
            {
                return this.disputeExplanationFieldSpecified;
            }
            set
            {
                this.disputeExplanationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeReasonCodeType DisputeReason
        {
            get
            {
                return this.disputeReasonField;
            }
            set
            {
                this.disputeReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeReasonSpecified
        {
            get
            {
                return this.disputeReasonFieldSpecified;
            }
            set
            {
                this.disputeReasonFieldSpecified = value;
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
