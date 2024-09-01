    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class EndItemRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private EndReasonCodeType endingReasonField;
        
        private bool endingReasonFieldSpecified;
        
        private string sellerInventoryIDField;
        
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
        public EndReasonCodeType EndingReason
        {
            get
            {
                return this.endingReasonField;
            }
            set
            {
                this.endingReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndingReasonSpecified
        {
            get
            {
                return this.endingReasonFieldSpecified;
            }
            set
            {
                this.endingReasonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerInventoryID
        {
            get
            {
                return this.sellerInventoryIDField;
            }
            set
            {
                this.sellerInventoryIDField = value;
            }
        }
    }
