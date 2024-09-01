    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemBidDetailsType
    {
        
        private string itemIDField;
        
        private string categoryIDField;
        
        private int bidCountField;
        
        private bool bidCountFieldSpecified;
        
        private string sellerIDField;
        
        private System.DateTime lastBidTimeField;
        
        private bool lastBidTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public string CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidCount
        {
            get
            {
                return this.bidCountField;
            }
            set
            {
                this.bidCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidCountSpecified
        {
            get
            {
                return this.bidCountFieldSpecified;
            }
            set
            {
                this.bidCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerID
        {
            get
            {
                return this.sellerIDField;
            }
            set
            {
                this.sellerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastBidTime
        {
            get
            {
                return this.lastBidTimeField;
            }
            set
            {
                this.lastBidTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastBidTimeSpecified
        {
            get
            {
                return this.lastBidTimeFieldSpecified;
            }
            set
            {
                this.lastBidTimeFieldSpecified = value;
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
