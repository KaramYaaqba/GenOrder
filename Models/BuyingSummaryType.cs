    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BuyingSummaryType
    {
        
        private int biddingCountField;
        
        private bool biddingCountFieldSpecified;
        
        private int winningCountField;
        
        private bool winningCountFieldSpecified;
        
        private AmountType totalWinningCostField;
        
        private int wonCountField;
        
        private bool wonCountFieldSpecified;
        
        private AmountType totalWonCostField;
        
        private int wonDurationInDaysField;
        
        private bool wonDurationInDaysFieldSpecified;
        
        private int bestOfferCountField;
        
        private bool bestOfferCountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BiddingCount
        {
            get
            {
                return this.biddingCountField;
            }
            set
            {
                this.biddingCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BiddingCountSpecified
        {
            get
            {
                return this.biddingCountFieldSpecified;
            }
            set
            {
                this.biddingCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WinningCount
        {
            get
            {
                return this.winningCountField;
            }
            set
            {
                this.winningCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WinningCountSpecified
        {
            get
            {
                return this.winningCountFieldSpecified;
            }
            set
            {
                this.winningCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalWinningCost
        {
            get
            {
                return this.totalWinningCostField;
            }
            set
            {
                this.totalWinningCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WonCount
        {
            get
            {
                return this.wonCountField;
            }
            set
            {
                this.wonCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WonCountSpecified
        {
            get
            {
                return this.wonCountFieldSpecified;
            }
            set
            {
                this.wonCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalWonCost
        {
            get
            {
                return this.totalWonCostField;
            }
            set
            {
                this.totalWonCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WonDurationInDays
        {
            get
            {
                return this.wonDurationInDaysField;
            }
            set
            {
                this.wonDurationInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WonDurationInDaysSpecified
        {
            get
            {
                return this.wonDurationInDaysFieldSpecified;
            }
            set
            {
                this.wonDurationInDaysFieldSpecified = value;
            }
        }
        
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
    }
