    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BiddingSummaryType
    {
        
        private int summaryDaysField;
        
        private bool summaryDaysFieldSpecified;
        
        private int totalBidsField;
        
        private bool totalBidsFieldSpecified;
        
        private int bidActivityWithSellerField;
        
        private bool bidActivityWithSellerFieldSpecified;
        
        private int bidsToUniqueSellersField;
        
        private bool bidsToUniqueSellersFieldSpecified;
        
        private int bidsToUniqueCategoriesField;
        
        private bool bidsToUniqueCategoriesFieldSpecified;
        
        private int bidRetractionsField;
        
        private bool bidRetractionsFieldSpecified;
        
        private ItemBidDetailsType[] itemBidDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int SummaryDays
        {
            get
            {
                return this.summaryDaysField;
            }
            set
            {
                this.summaryDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SummaryDaysSpecified
        {
            get
            {
                return this.summaryDaysFieldSpecified;
            }
            set
            {
                this.summaryDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalBids
        {
            get
            {
                return this.totalBidsField;
            }
            set
            {
                this.totalBidsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalBidsSpecified
        {
            get
            {
                return this.totalBidsFieldSpecified;
            }
            set
            {
                this.totalBidsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidActivityWithSeller
        {
            get
            {
                return this.bidActivityWithSellerField;
            }
            set
            {
                this.bidActivityWithSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidActivityWithSellerSpecified
        {
            get
            {
                return this.bidActivityWithSellerFieldSpecified;
            }
            set
            {
                this.bidActivityWithSellerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidsToUniqueSellers
        {
            get
            {
                return this.bidsToUniqueSellersField;
            }
            set
            {
                this.bidsToUniqueSellersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidsToUniqueSellersSpecified
        {
            get
            {
                return this.bidsToUniqueSellersFieldSpecified;
            }
            set
            {
                this.bidsToUniqueSellersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidsToUniqueCategories
        {
            get
            {
                return this.bidsToUniqueCategoriesField;
            }
            set
            {
                this.bidsToUniqueCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidsToUniqueCategoriesSpecified
        {
            get
            {
                return this.bidsToUniqueCategoriesFieldSpecified;
            }
            set
            {
                this.bidsToUniqueCategoriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidRetractions
        {
            get
            {
                return this.bidRetractionsField;
            }
            set
            {
                this.bidRetractionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidRetractionsSpecified
        {
            get
            {
                return this.bidRetractionsFieldSpecified;
            }
            set
            {
                this.bidRetractionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemBidDetails" )]
        public ItemBidDetailsType[] ItemBidDetails
        {
            get
            {
                return this.itemBidDetailsField;
            }
            set
            {
                this.itemBidDetailsField = value;
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
