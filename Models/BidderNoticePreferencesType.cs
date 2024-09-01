    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BidderNoticePreferencesType
    {
        
        private bool unsuccessfulBidderNoticeIncludeMyItemsField;
        
        private bool unsuccessfulBidderNoticeIncludeMyItemsFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UnsuccessfulBidderNoticeIncludeMyItems
        {
            get
            {
                return this.unsuccessfulBidderNoticeIncludeMyItemsField;
            }
            set
            {
                this.unsuccessfulBidderNoticeIncludeMyItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnsuccessfulBidderNoticeIncludeMyItemsSpecified
        {
            get
            {
                return this.unsuccessfulBidderNoticeIncludeMyItemsFieldSpecified;
            }
            set
            {
                this.unsuccessfulBidderNoticeIncludeMyItemsFieldSpecified = value;
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
