    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ListingDetailsType
    {
        
        private bool adultField;
        
        private bool adultFieldSpecified;
        
        private bool bindingAuctionField;
        
        private bool bindingAuctionFieldSpecified;
        
        private bool checkoutEnabledField;
        
        private bool checkoutEnabledFieldSpecified;
        
        private AmountType convertedBuyItNowPriceField;
        
        private AmountType convertedStartPriceField;
        
        private AmountType convertedReservePriceField;
        
        private bool hasReservePriceField;
        
        private bool hasReservePriceFieldSpecified;
        
        private string relistedItemIDField;
        
        private string secondChanceOriginalItemIDField;
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private string viewItemURLField;
        
        private bool hasUnansweredQuestionsField;
        
        private bool hasUnansweredQuestionsFieldSpecified;
        
        private bool hasPublicMessagesField;
        
        private bool hasPublicMessagesFieldSpecified;
        
        private bool buyItNowAvailableField;
        
        private bool buyItNowAvailableFieldSpecified;
        
        private SellerBusinessCodeType sellerBusinessTypeField;
        
        private bool sellerBusinessTypeFieldSpecified;
        
        private AmountType minimumBestOfferPriceField;
        
        private string minimumBestOfferMessageField;
        
        private string localListingDistanceField;
        
        private string tCROriginalItemIDField;
        
        private string viewItemURLForNaturalSearchField;
        
        private bool payPerLeadEnabledField;
        
        private bool payPerLeadEnabledFieldSpecified;
        
        private AmountType bestOfferAutoAcceptPriceField;
        
        private EndReasonCodeType endingReasonField;
        
        private bool endingReasonFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Adult
        {
            get
            {
                return this.adultField;
            }
            set
            {
                this.adultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdultSpecified
        {
            get
            {
                return this.adultFieldSpecified;
            }
            set
            {
                this.adultFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BindingAuction
        {
            get
            {
                return this.bindingAuctionField;
            }
            set
            {
                this.bindingAuctionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BindingAuctionSpecified
        {
            get
            {
                return this.bindingAuctionFieldSpecified;
            }
            set
            {
                this.bindingAuctionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CheckoutEnabled
        {
            get
            {
                return this.checkoutEnabledField;
            }
            set
            {
                this.checkoutEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckoutEnabledSpecified
        {
            get
            {
                return this.checkoutEnabledFieldSpecified;
            }
            set
            {
                this.checkoutEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedBuyItNowPrice
        {
            get
            {
                return this.convertedBuyItNowPriceField;
            }
            set
            {
                this.convertedBuyItNowPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedStartPrice
        {
            get
            {
                return this.convertedStartPriceField;
            }
            set
            {
                this.convertedStartPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedReservePrice
        {
            get
            {
                return this.convertedReservePriceField;
            }
            set
            {
                this.convertedReservePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasReservePrice
        {
            get
            {
                return this.hasReservePriceField;
            }
            set
            {
                this.hasReservePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasReservePriceSpecified
        {
            get
            {
                return this.hasReservePriceFieldSpecified;
            }
            set
            {
                this.hasReservePriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RelistedItemID
        {
            get
            {
                return this.relistedItemIDField;
            }
            set
            {
                this.relistedItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SecondChanceOriginalItemID
        {
            get
            {
                return this.secondChanceOriginalItemIDField;
            }
            set
            {
                this.secondChanceOriginalItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeSpecified
        {
            get
            {
                return this.endTimeFieldSpecified;
            }
            set
            {
                this.endTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ViewItemURL
        {
            get
            {
                return this.viewItemURLField;
            }
            set
            {
                this.viewItemURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasUnansweredQuestions
        {
            get
            {
                return this.hasUnansweredQuestionsField;
            }
            set
            {
                this.hasUnansweredQuestionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasUnansweredQuestionsSpecified
        {
            get
            {
                return this.hasUnansweredQuestionsFieldSpecified;
            }
            set
            {
                this.hasUnansweredQuestionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasPublicMessages
        {
            get
            {
                return this.hasPublicMessagesField;
            }
            set
            {
                this.hasPublicMessagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasPublicMessagesSpecified
        {
            get
            {
                return this.hasPublicMessagesFieldSpecified;
            }
            set
            {
                this.hasPublicMessagesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BuyItNowAvailable
        {
            get
            {
                return this.buyItNowAvailableField;
            }
            set
            {
                this.buyItNowAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyItNowAvailableSpecified
        {
            get
            {
                return this.buyItNowAvailableFieldSpecified;
            }
            set
            {
                this.buyItNowAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerBusinessCodeType SellerBusinessType
        {
            get
            {
                return this.sellerBusinessTypeField;
            }
            set
            {
                this.sellerBusinessTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerBusinessTypeSpecified
        {
            get
            {
                return this.sellerBusinessTypeFieldSpecified;
            }
            set
            {
                this.sellerBusinessTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MinimumBestOfferPrice
        {
            get
            {
                return this.minimumBestOfferPriceField;
            }
            set
            {
                this.minimumBestOfferPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MinimumBestOfferMessage
        {
            get
            {
                return this.minimumBestOfferMessageField;
            }
            set
            {
                this.minimumBestOfferMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string LocalListingDistance
        {
            get
            {
                return this.localListingDistanceField;
            }
            set
            {
                this.localListingDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TCROriginalItemID
        {
            get
            {
                return this.tCROriginalItemIDField;
            }
            set
            {
                this.tCROriginalItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ViewItemURLForNaturalSearch
        {
            get
            {
                return this.viewItemURLForNaturalSearchField;
            }
            set
            {
                this.viewItemURLForNaturalSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PayPerLeadEnabled
        {
            get
            {
                return this.payPerLeadEnabledField;
            }
            set
            {
                this.payPerLeadEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPerLeadEnabledSpecified
        {
            get
            {
                return this.payPerLeadEnabledFieldSpecified;
            }
            set
            {
                this.payPerLeadEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType BestOfferAutoAcceptPrice
        {
            get
            {
                return this.bestOfferAutoAcceptPriceField;
            }
            set
            {
                this.bestOfferAutoAcceptPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public EndReasonCodeType EndingReason
        {
            get
            {
                return this.endingReasonField;
            }
            set
            {
                this.endingReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndingReasonSpecified
        {
            get
            {
                return this.endingReasonFieldSpecified;
            }
            set
            {
                this.endingReasonFieldSpecified = value;
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
