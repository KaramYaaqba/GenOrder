    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class LeaveFeedbackResponseType : AbstractResponseType
    {
        
        private string feedbackIDField;
        
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
    }
