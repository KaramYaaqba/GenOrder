    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAllBiddersRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private GetAllBiddersModeCodeType callModeField;
        
        private bool callModeFieldSpecified;
        
        private bool includeBiddingSummaryField;
        
        private bool includeBiddingSummaryFieldSpecified;
        
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
        public GetAllBiddersModeCodeType CallMode
        {
            get
            {
                return this.callModeField;
            }
            set
            {
                this.callModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CallModeSpecified
        {
            get
            {
                return this.callModeFieldSpecified;
            }
            set
            {
                this.callModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeBiddingSummary
        {
            get
            {
                return this.includeBiddingSummaryField;
            }
            set
            {
                this.includeBiddingSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeBiddingSummarySpecified
        {
            get
            {
                return this.includeBiddingSummaryFieldSpecified;
            }
            set
            {
                this.includeBiddingSummaryFieldSpecified = value;
            }
        }
    }
