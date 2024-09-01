    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetFeedbackResponseType : AbstractResponseType
    {
        
        private FeedbackDetailType[] feedbackDetailArrayField;
        
        private int feedbackDetailItemTotalField;
        
        private bool feedbackDetailItemTotalFieldSpecified;
        
        private FeedbackSummaryType feedbackSummaryField;
        
        private int feedbackScoreField;
        
        private bool feedbackScoreFieldSpecified;
        
        private PaginationResultType paginationResultField;
        
        private int entriesPerPageField;
        
        private bool entriesPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackDetail", IsNullable=false)]
        public FeedbackDetailType[] FeedbackDetailArray
        {
            get
            {
                return this.feedbackDetailArrayField;
            }
            set
            {
                this.feedbackDetailArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FeedbackDetailItemTotal
        {
            get
            {
                return this.feedbackDetailItemTotalField;
            }
            set
            {
                this.feedbackDetailItemTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackDetailItemTotalSpecified
        {
            get
            {
                return this.feedbackDetailItemTotalFieldSpecified;
            }
            set
            {
                this.feedbackDetailItemTotalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackSummaryType FeedbackSummary
        {
            get
            {
                return this.feedbackSummaryField;
            }
            set
            {
                this.feedbackSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FeedbackScore
        {
            get
            {
                return this.feedbackScoreField;
            }
            set
            {
                this.feedbackScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackScoreSpecified
        {
            get
            {
                return this.feedbackScoreFieldSpecified;
            }
            set
            {
                this.feedbackScoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationResultType PaginationResult
        {
            get
            {
                return this.paginationResultField;
            }
            set
            {
                this.paginationResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int EntriesPerPage
        {
            get
            {
                return this.entriesPerPageField;
            }
            set
            {
                this.entriesPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntriesPerPageSpecified
        {
            get
            {
                return this.entriesPerPageFieldSpecified;
            }
            set
            {
                this.entriesPerPageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageNumberSpecified
        {
            get
            {
                return this.pageNumberFieldSpecified;
            }
            set
            {
                this.pageNumberFieldSpecified = value;
            }
        }
    }
