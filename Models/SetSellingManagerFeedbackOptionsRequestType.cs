    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetSellingManagerFeedbackOptionsRequestType : AbstractRequestType
    {
        
        private AutomatedLeaveFeedbackEventCodeType automatedLeaveFeedbackEventField;
        
        private bool automatedLeaveFeedbackEventFieldSpecified;
        
        private string[] storedCommentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AutomatedLeaveFeedbackEventCodeType AutomatedLeaveFeedbackEvent
        {
            get
            {
                return this.automatedLeaveFeedbackEventField;
            }
            set
            {
                this.automatedLeaveFeedbackEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutomatedLeaveFeedbackEventSpecified
        {
            get
            {
                return this.automatedLeaveFeedbackEventFieldSpecified;
            }
            set
            {
                this.automatedLeaveFeedbackEventFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("StoredCommentText", IsNullable=false)]
        public string[] StoredComments
        {
            get
            {
                return this.storedCommentsField;
            }
            set
            {
                this.storedCommentsField = value;
            }
        }
    }
