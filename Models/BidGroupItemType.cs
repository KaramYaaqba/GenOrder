    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BidGroupItemType
    {
        
        private ItemType itemField;
        
        private BidGroupItemStatusCodeType bidGroupItemStatusField;
        
        private bool bidGroupItemStatusFieldSpecified;
        
        private AmountType maxBidAmountField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BidGroupItemStatusCodeType BidGroupItemStatus
        {
            get
            {
                return this.bidGroupItemStatusField;
            }
            set
            {
                this.bidGroupItemStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidGroupItemStatusSpecified
        {
            get
            {
                return this.bidGroupItemStatusFieldSpecified;
            }
            set
            {
                this.bidGroupItemStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MaxBidAmount
        {
            get
            {
                return this.maxBidAmountField;
            }
            set
            {
                this.maxBidAmountField = value;
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
