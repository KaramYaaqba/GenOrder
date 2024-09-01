    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BiddingDetailsType
    {
        
        private AmountType convertedMaxBidField;
        
        private AmountType maxBidField;
        
        private int quantityBidField;
        
        private bool quantityBidFieldSpecified;
        
        private int quantityWonField;
        
        private bool quantityWonFieldSpecified;
        
        private bool winningField;
        
        private bool winningFieldSpecified;
        
        private bool bidAssistantField;
        
        private bool bidAssistantFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedMaxBid
        {
            get
            {
                return this.convertedMaxBidField;
            }
            set
            {
                this.convertedMaxBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MaxBid
        {
            get
            {
                return this.maxBidField;
            }
            set
            {
                this.maxBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityBid
        {
            get
            {
                return this.quantityBidField;
            }
            set
            {
                this.quantityBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityBidSpecified
        {
            get
            {
                return this.quantityBidFieldSpecified;
            }
            set
            {
                this.quantityBidFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityWon
        {
            get
            {
                return this.quantityWonField;
            }
            set
            {
                this.quantityWonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityWonSpecified
        {
            get
            {
                return this.quantityWonFieldSpecified;
            }
            set
            {
                this.quantityWonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Winning
        {
            get
            {
                return this.winningField;
            }
            set
            {
                this.winningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WinningSpecified
        {
            get
            {
                return this.winningFieldSpecified;
            }
            set
            {
                this.winningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BidAssistant
        {
            get
            {
                return this.bidAssistantField;
            }
            set
            {
                this.bidAssistantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidAssistantSpecified
        {
            get
            {
                return this.bidAssistantFieldSpecified;
            }
            set
            {
                this.bidAssistantFieldSpecified = value;
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
