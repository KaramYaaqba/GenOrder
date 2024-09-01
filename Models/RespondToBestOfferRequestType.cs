    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RespondToBestOfferRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string[] bestOfferIDField;
        
        private BestOfferActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private string sellerResponseField;
        
        private AmountType counterOfferPriceField;
        
        private int counterOfferQuantityField;
        
        private bool counterOfferQuantityFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute("BestOfferID" )]
        public string[] BestOfferID
        {
            get
            {
                return this.bestOfferIDField;
            }
            set
            {
                this.bestOfferIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferActionCodeType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerResponse
        {
            get
            {
                return this.sellerResponseField;
            }
            set
            {
                this.sellerResponseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CounterOfferPrice
        {
            get
            {
                return this.counterOfferPriceField;
            }
            set
            {
                this.counterOfferPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CounterOfferQuantity
        {
            get
            {
                return this.counterOfferQuantityField;
            }
            set
            {
                this.counterOfferQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterOfferQuantitySpecified
        {
            get
            {
                return this.counterOfferQuantityFieldSpecified;
            }
            set
            {
                this.counterOfferQuantityFieldSpecified = value;
            }
        }
    }
