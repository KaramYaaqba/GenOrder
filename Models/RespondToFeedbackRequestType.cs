    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RespondToFeedbackRequestType : AbstractRequestType
    {
        
        private string feedbackIDField;
        
        private string itemIDField;
        
        private string transactionIDField;
        
        private string targetUserIDField;
        
        private FeedbackResponseCodeType responseTypeField;
        
        private bool responseTypeFieldSpecified;
        
        private string responseTextField;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FeedbackID
        {
            get
            {
                return this.feedbackIDField;
            }
            set
            {
                this.feedbackIDField = value;
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
        public string TargetUserID
        {
            get
            {
                return this.targetUserIDField;
            }
            set
            {
                this.targetUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackResponseCodeType ResponseType
        {
            get
            {
                return this.responseTypeField;
            }
            set
            {
                this.responseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResponseTypeSpecified
        {
            get
            {
                return this.responseTypeFieldSpecified;
            }
            set
            {
                this.responseTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ResponseText
        {
            get
            {
                return this.responseTextField;
            }
            set
            {
                this.responseTextField = value;
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
