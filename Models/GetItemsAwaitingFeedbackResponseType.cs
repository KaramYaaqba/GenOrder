    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemsAwaitingFeedbackResponseType : AbstractResponseType
    {
        
        private PaginatedTransactionArrayType itemsAwaitingFeedbackField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedTransactionArrayType ItemsAwaitingFeedback
        {
            get
            {
                return this.itemsAwaitingFeedbackField;
            }
            set
            {
                this.itemsAwaitingFeedbackField = value;
            }
        }
    }
