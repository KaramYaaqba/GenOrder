    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingSummaryType
    {
        
        private int activeAuctionCountField;
        
        private bool activeAuctionCountFieldSpecified;
        
        private int auctionSellingCountField;
        
        private bool auctionSellingCountFieldSpecified;
        
        private int auctionBidCountField;
        
        private bool auctionBidCountFieldSpecified;
        
        private AmountType totalAuctionSellingValueField;
        
        private int totalSoldCountField;
        
        private bool totalSoldCountFieldSpecified;
        
        private AmountType totalSoldValueField;
        
        private int soldDurationInDaysField;
        
        private bool soldDurationInDaysFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ActiveAuctionCount
        {
            get
            {
                return this.activeAuctionCountField;
            }
            set
            {
                this.activeAuctionCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveAuctionCountSpecified
        {
            get
            {
                return this.activeAuctionCountFieldSpecified;
            }
            set
            {
                this.activeAuctionCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int AuctionSellingCount
        {
            get
            {
                return this.auctionSellingCountField;
            }
            set
            {
                this.auctionSellingCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AuctionSellingCountSpecified
        {
            get
            {
                return this.auctionSellingCountFieldSpecified;
            }
            set
            {
                this.auctionSellingCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int AuctionBidCount
        {
            get
            {
                return this.auctionBidCountField;
            }
            set
            {
                this.auctionBidCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AuctionBidCountSpecified
        {
            get
            {
                return this.auctionBidCountFieldSpecified;
            }
            set
            {
                this.auctionBidCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalAuctionSellingValue
        {
            get
            {
                return this.totalAuctionSellingValueField;
            }
            set
            {
                this.totalAuctionSellingValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalSoldCount
        {
            get
            {
                return this.totalSoldCountField;
            }
            set
            {
                this.totalSoldCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSoldCountSpecified
        {
            get
            {
                return this.totalSoldCountFieldSpecified;
            }
            set
            {
                this.totalSoldCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalSoldValue
        {
            get
            {
                return this.totalSoldValueField;
            }
            set
            {
                this.totalSoldValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int SoldDurationInDays
        {
            get
            {
                return this.soldDurationInDaysField;
            }
            set
            {
                this.soldDurationInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoldDurationInDaysSpecified
        {
            get
            {
                return this.soldDurationInDaysFieldSpecified;
            }
            set
            {
                this.soldDurationInDaysFieldSpecified = value;
            }
        }
    }
