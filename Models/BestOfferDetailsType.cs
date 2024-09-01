    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BestOfferDetailsType
    {
        
        private int bestOfferCountField;
        
        private bool bestOfferCountFieldSpecified;
        
        private bool bestOfferEnabledField;
        
        private bool bestOfferEnabledFieldSpecified;
        
        private AmountType bestOfferField;
        
        private BestOfferStatusCodeType bestOfferStatusField;
        
        private bool bestOfferStatusFieldSpecified;
        
        private BestOfferTypeCodeType bestOfferTypeField;
        
        private bool bestOfferTypeFieldSpecified;
        
        private bool newBestOfferField;
        
        private bool newBestOfferFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BestOfferCount
        {
            get
            {
                return this.bestOfferCountField;
            }
            set
            {
                this.bestOfferCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferCountSpecified
        {
            get
            {
                return this.bestOfferCountFieldSpecified;
            }
            set
            {
                this.bestOfferCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BestOfferEnabled
        {
            get
            {
                return this.bestOfferEnabledField;
            }
            set
            {
                this.bestOfferEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferEnabledSpecified
        {
            get
            {
                return this.bestOfferEnabledFieldSpecified;
            }
            set
            {
                this.bestOfferEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType BestOffer
        {
            get
            {
                return this.bestOfferField;
            }
            set
            {
                this.bestOfferField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferStatusCodeType BestOfferStatus
        {
            get
            {
                return this.bestOfferStatusField;
            }
            set
            {
                this.bestOfferStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferStatusSpecified
        {
            get
            {
                return this.bestOfferStatusFieldSpecified;
            }
            set
            {
                this.bestOfferStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferTypeCodeType BestOfferType
        {
            get
            {
                return this.bestOfferTypeField;
            }
            set
            {
                this.bestOfferTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferTypeSpecified
        {
            get
            {
                return this.bestOfferTypeFieldSpecified;
            }
            set
            {
                this.bestOfferTypeFieldSpecified = value;
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
