    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetFeedbackRequestType : AbstractRequestType
    {
        
        private string userIDField;
        
        private string feedbackIDField;
        
        private string itemIDField;
        
        private string transactionIDField;
        
        private CommentTypeCodeType[] commentTypeField;
        
        private FeedbackTypeCodeType feedbackTypeField;
        
        private bool feedbackTypeFieldSpecified;
        
        private PaginationType paginationField;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute("CommentType" )]
        public CommentTypeCodeType[] CommentType
        {
            get
            {
                return this.commentTypeField;
            }
            set
            {
                this.commentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackTypeCodeType FeedbackType
        {
            get
            {
                return this.feedbackTypeField;
            }
            set
            {
                this.feedbackTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackTypeSpecified
        {
            get
            {
                return this.feedbackTypeFieldSpecified;
            }
            set
            {
                this.feedbackTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
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
