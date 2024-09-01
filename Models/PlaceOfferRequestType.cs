    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PlaceOfferRequestType : AbstractRequestType
    {
        
        private OfferType offerField;
        
        private string itemIDField;
        
        private bool blockOnWarningField;
        
        private bool blockOnWarningFieldSpecified;
        
        private AffiliateTrackingDetailsType affiliateTrackingDetailsField;
        
        private NameValueListType[] variationSpecificsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public OfferType Offer
        {
            get
            {
                return this.offerField;
            }
            set
            {
                this.offerField = value;
            }
        }
        
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
        public bool BlockOnWarning
        {
            get
            {
                return this.blockOnWarningField;
            }
            set
            {
                this.blockOnWarningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BlockOnWarningSpecified
        {
            get
            {
                return this.blockOnWarningFieldSpecified;
            }
            set
            {
                this.blockOnWarningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AffiliateTrackingDetailsType AffiliateTrackingDetails
        {
            get
            {
                return this.affiliateTrackingDetailsField;
            }
            set
            {
                this.affiliateTrackingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NameValueList", IsNullable=false)]
        public NameValueListType[] VariationSpecifics
        {
            get
            {
                return this.variationSpecificsField;
            }
            set
            {
                this.variationSpecificsField = value;
            }
        }
    }
