    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingStatusType
    {
        
        private int bidCountField;
        
        private bool bidCountFieldSpecified;
        
        private AmountType bidIncrementField;
        
        private AmountType convertedCurrentPriceField;
        
        private AmountType currentPriceField;
        
        private UserType highBidderField;
        
        private int leadCountField;
        
        private bool leadCountFieldSpecified;
        
        private AmountType minimumToBidField;
        
        private int quantitySoldField;
        
        private bool quantitySoldFieldSpecified;
        
        private bool reserveMetField;
        
        private bool reserveMetFieldSpecified;
        
        private bool secondChanceEligibleField;
        
        private bool secondChanceEligibleFieldSpecified;
        
        private long bidderCountField;
        
        private bool bidderCountFieldSpecified;
        
        private ListingStatusCodeType listingStatusField;
        
        private bool listingStatusFieldSpecified;
        
        private AmountType finalValueFeeField;
        
        private PromotionalSaleDetailsType promotionalSaleDetailsField;
        
        private bool adminEndedField;
        
        private bool adminEndedFieldSpecified;
        
        private bool soldAsBinField;
        
        private bool soldAsBinFieldSpecified;
        
        private int quantitySoldByPickupInStoreField;
        
        private bool quantitySoldByPickupInStoreFieldSpecified;
        
        private SuggestedBidValueType suggestedBidValuesField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public AmountType BidIncrement
        {
            get
            {
                return this.bidIncrementField;
            }
            set
            {
                this.bidIncrementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedCurrentPrice
        {
            get
            {
                return this.convertedCurrentPriceField;
            }
            set
            {
                this.convertedCurrentPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CurrentPrice
        {
            get
            {
                return this.currentPriceField;
            }
            set
            {
                this.currentPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType HighBidder
        {
            get
            {
                return this.highBidderField;
            }
            set
            {
                this.highBidderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int LeadCount
        {
            get
            {
                return this.leadCountField;
            }
            set
            {
                this.leadCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeadCountSpecified
        {
            get
            {
                return this.leadCountFieldSpecified;
            }
            set
            {
                this.leadCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MinimumToBid
        {
            get
            {
                return this.minimumToBidField;
            }
            set
            {
                this.minimumToBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantitySold
        {
            get
            {
                return this.quantitySoldField;
            }
            set
            {
                this.quantitySoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySoldSpecified
        {
            get
            {
                return this.quantitySoldFieldSpecified;
            }
            set
            {
                this.quantitySoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReserveMet
        {
            get
            {
                return this.reserveMetField;
            }
            set
            {
                this.reserveMetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReserveMetSpecified
        {
            get
            {
                return this.reserveMetFieldSpecified;
            }
            set
            {
                this.reserveMetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SecondChanceEligible
        {
            get
            {
                return this.secondChanceEligibleField;
            }
            set
            {
                this.secondChanceEligibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecondChanceEligibleSpecified
        {
            get
            {
                return this.secondChanceEligibleFieldSpecified;
            }
            set
            {
                this.secondChanceEligibleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long BidderCount
        {
            get
            {
                return this.bidderCountField;
            }
            set
            {
                this.bidderCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidderCountSpecified
        {
            get
            {
                return this.bidderCountFieldSpecified;
            }
            set
            {
                this.bidderCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingStatusCodeType ListingStatus
        {
            get
            {
                return this.listingStatusField;
            }
            set
            {
                this.listingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingStatusSpecified
        {
            get
            {
                return this.listingStatusFieldSpecified;
            }
            set
            {
                this.listingStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType FinalValueFee
        {
            get
            {
                return this.finalValueFeeField;
            }
            set
            {
                this.finalValueFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalSaleDetailsType PromotionalSaleDetails
        {
            get
            {
                return this.promotionalSaleDetailsField;
            }
            set
            {
                this.promotionalSaleDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AdminEnded
        {
            get
            {
                return this.adminEndedField;
            }
            set
            {
                this.adminEndedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdminEndedSpecified
        {
            get
            {
                return this.adminEndedFieldSpecified;
            }
            set
            {
                this.adminEndedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SoldAsBin
        {
            get
            {
                return this.soldAsBinField;
            }
            set
            {
                this.soldAsBinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoldAsBinSpecified
        {
            get
            {
                return this.soldAsBinFieldSpecified;
            }
            set
            {
                this.soldAsBinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantitySoldByPickupInStore
        {
            get
            {
                return this.quantitySoldByPickupInStoreField;
            }
            set
            {
                this.quantitySoldByPickupInStoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySoldByPickupInStoreSpecified
        {
            get
            {
                return this.quantitySoldByPickupInStoreFieldSpecified;
            }
            set
            {
                this.quantitySoldByPickupInStoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SuggestedBidValueType SuggestedBidValues
        {
            get
            {
                return this.suggestedBidValuesField;
            }
            set
            {
                this.suggestedBidValuesField = value;
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
