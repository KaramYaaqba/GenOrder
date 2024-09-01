    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FeedbackDetailType
    {
        
        private string commentingUserField;
        
        private FeedbackRatingStarCodeType feedbackRatingStarField;
        
        private bool feedbackRatingStarFieldSpecified;
        
        private int commentingUserScoreField;
        
        private bool commentingUserScoreFieldSpecified;
        
        private string commentTextField;
        
        private System.DateTime commentTimeField;
        
        private bool commentTimeFieldSpecified;
        
        private CommentTypeCodeType commentTypeField;
        
        private bool commentTypeFieldSpecified;
        
        private string feedbackResponseField;
        
        private string followupField;
        
        private string itemIDField;
        
        private TradingRoleCodeType roleField;
        
        private bool roleFieldSpecified;
        
        private string itemTitleField;
        
        private AmountType itemPriceField;
        
        private string feedbackIDField;
        
        private string transactionIDField;
        
        private bool commentReplacedField;
        
        private bool commentReplacedFieldSpecified;
        
        private bool responseReplacedField;
        
        private bool responseReplacedFieldSpecified;
        
        private bool followUpReplacedField;
        
        private bool followUpReplacedFieldSpecified;
        
        private bool countableField;
        
        private bool countableFieldSpecified;
        
        private bool feedbackRevisedField;
        
        private bool feedbackRevisedFieldSpecified;
        
        private string orderLineItemIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CommentingUser
        {
            get
            {
                return this.commentingUserField;
            }
            set
            {
                this.commentingUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackRatingStarCodeType FeedbackRatingStar
        {
            get
            {
                return this.feedbackRatingStarField;
            }
            set
            {
                this.feedbackRatingStarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackRatingStarSpecified
        {
            get
            {
                return this.feedbackRatingStarFieldSpecified;
            }
            set
            {
                this.feedbackRatingStarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CommentingUserScore
        {
            get
            {
                return this.commentingUserScoreField;
            }
            set
            {
                this.commentingUserScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentingUserScoreSpecified
        {
            get
            {
                return this.commentingUserScoreFieldSpecified;
            }
            set
            {
                this.commentingUserScoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CommentText
        {
            get
            {
                return this.commentTextField;
            }
            set
            {
                this.commentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CommentTime
        {
            get
            {
                return this.commentTimeField;
            }
            set
            {
                this.commentTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentTimeSpecified
        {
            get
            {
                return this.commentTimeFieldSpecified;
            }
            set
            {
                this.commentTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CommentTypeCodeType CommentType
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentTypeSpecified
        {
            get
            {
                return this.commentTypeFieldSpecified;
            }
            set
            {
                this.commentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FeedbackResponse
        {
            get
            {
                return this.feedbackResponseField;
            }
            set
            {
                this.feedbackResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Followup
        {
            get
            {
                return this.followupField;
            }
            set
            {
                this.followupField = value;
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
        public TradingRoleCodeType Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleSpecified
        {
            get
            {
                return this.roleFieldSpecified;
            }
            set
            {
                this.roleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ItemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
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
        public bool CommentReplaced
        {
            get
            {
                return this.commentReplacedField;
            }
            set
            {
                this.commentReplacedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentReplacedSpecified
        {
            get
            {
                return this.commentReplacedFieldSpecified;
            }
            set
            {
                this.commentReplacedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ResponseReplaced
        {
            get
            {
                return this.responseReplacedField;
            }
            set
            {
                this.responseReplacedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResponseReplacedSpecified
        {
            get
            {
                return this.responseReplacedFieldSpecified;
            }
            set
            {
                this.responseReplacedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FollowUpReplaced
        {
            get
            {
                return this.followUpReplacedField;
            }
            set
            {
                this.followUpReplacedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FollowUpReplacedSpecified
        {
            get
            {
                return this.followUpReplacedFieldSpecified;
            }
            set
            {
                this.followUpReplacedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Countable
        {
            get
            {
                return this.countableField;
            }
            set
            {
                this.countableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountableSpecified
        {
            get
            {
                return this.countableFieldSpecified;
            }
            set
            {
                this.countableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FeedbackRevised
        {
            get
            {
                return this.feedbackRevisedField;
            }
            set
            {
                this.feedbackRevisedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackRevisedSpecified
        {
            get
            {
                return this.feedbackRevisedFieldSpecified;
            }
            set
            {
                this.feedbackRevisedFieldSpecified = value;
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
