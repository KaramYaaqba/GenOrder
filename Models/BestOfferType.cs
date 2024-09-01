    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BestOfferType
    {
        
        private string bestOfferIDField;
        
        private System.DateTime expirationTimeField;
        
        private bool expirationTimeFieldSpecified;
        
        private UserType buyerField;
        
        private AmountType priceField;
        
        private BestOfferStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private int quantityField;
        
        private bool quantityFieldSpecified;
        
        private string buyerMessageField;
        
        private string sellerMessageField;
        
        private BestOfferTypeCodeType bestOfferCodeTypeField;
        
        private bool bestOfferCodeTypeFieldSpecified;
        
        private string callStatusField;
        
        private bool newBestOfferField;
        
        private bool newBestOfferFieldSpecified;
        
        private bool immediatePayEligibleField;
        
        private bool immediatePayEligibleFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BestOfferID
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
        public System.DateTime ExpirationTime
        {
            get
            {
                return this.expirationTimeField;
            }
            set
            {
                this.expirationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationTimeSpecified
        {
            get
            {
                return this.expirationTimeFieldSpecified;
            }
            set
            {
                this.expirationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType Buyer
        {
            get
            {
                return this.buyerField;
            }
            set
            {
                this.buyerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferStatusCodeType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerMessage
        {
            get
            {
                return this.buyerMessageField;
            }
            set
            {
                this.buyerMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerMessage
        {
            get
            {
                return this.sellerMessageField;
            }
            set
            {
                this.sellerMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferTypeCodeType BestOfferCodeType
        {
            get
            {
                return this.bestOfferCodeTypeField;
            }
            set
            {
                this.bestOfferCodeTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferCodeTypeSpecified
        {
            get
            {
                return this.bestOfferCodeTypeFieldSpecified;
            }
            set
            {
                this.bestOfferCodeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CallStatus
        {
            get
            {
                return this.callStatusField;
            }
            set
            {
                this.callStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool NewBestOffer
        {
            get
            {
                return this.newBestOfferField;
            }
            set
            {
                this.newBestOfferField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewBestOfferSpecified
        {
            get
            {
                return this.newBestOfferFieldSpecified;
            }
            set
            {
                this.newBestOfferFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ImmediatePayEligible
        {
            get
            {
                return this.immediatePayEligibleField;
            }
            set
            {
                this.immediatePayEligibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImmediatePayEligibleSpecified
        {
            get
            {
                return this.immediatePayEligibleFieldSpecified;
            }
            set
            {
                this.immediatePayEligibleFieldSpecified = value;
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
