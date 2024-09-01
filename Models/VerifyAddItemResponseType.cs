    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VerifyAddItemResponseType : AbstractResponseType
    {
        
        private string itemIDField;
        
        private FeeType[] feesField;
        
        private bool expressListingField;
        
        private bool expressListingFieldSpecified;
        
        private ExpressItemRequirementsType expressItemRequirementsField;
        
        private string categoryIDField;
        
        private string category2IDField;
        
        private DiscountReasonCodeType[] discountReasonField;
        
        private ProductSuggestionsType productSuggestionsField;
        
        private ListingRecommendationsType listingRecommendationsField;
        
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
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExpressListing
        {
            get
            {
                return this.expressListingField;
            }
            set
            {
                this.expressListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpressListingSpecified
        {
            get
            {
                return this.expressListingFieldSpecified;
            }
            set
            {
                this.expressListingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ExpressItemRequirementsType ExpressItemRequirements
        {
            get
            {
                return this.expressItemRequirementsField;
            }
            set
            {
                this.expressItemRequirementsField = value;
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
        public string Category2ID
        {
            get
            {
                return this.category2IDField;
            }
            set
            {
                this.category2IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscountReason" )]
        public DiscountReasonCodeType[] DiscountReason
        {
            get
            {
                return this.discountReasonField;
            }
            set
            {
                this.discountReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ProductSuggestionsType ProductSuggestions
        {
            get
            {
                return this.productSuggestionsField;
            }
            set
            {
                this.productSuggestionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingRecommendationsType ListingRecommendations
        {
            get
            {
                return this.listingRecommendationsField;
            }
            set
            {
                this.listingRecommendationsField = value;
            }
        }
    }
