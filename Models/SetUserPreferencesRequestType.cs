    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetUserPreferencesRequestType : AbstractRequestType
    {
        
        private BidderNoticePreferencesType bidderNoticePreferencesField;
        
        private CombinedPaymentPreferencesType combinedPaymentPreferencesField;
        
        private CrossPromotionPreferencesType crossPromotionPreferencesField;
        
        private SellerPaymentPreferencesType sellerPaymentPreferencesField;
        
        private SellerFavoriteItemPreferencesType sellerFavoriteItemPreferencesField;
        
        private EndOfAuctionEmailPreferencesType endOfAuctionEmailPreferencesField;
        
        private bool emailShipmentTrackingNumberPreferenceField;
        
        private bool emailShipmentTrackingNumberPreferenceFieldSpecified;
        
        private bool requiredShipPhoneNumberPreferenceField;
        
        private bool requiredShipPhoneNumberPreferenceFieldSpecified;
        
        private UnpaidItemAssistancePreferencesType unpaidItemAssistancePreferencesField;
        
        private PurchaseReminderEmailPreferencesType purchaseReminderEmailPreferencesField;
        
        private bool sellerThirdPartyCheckoutDisabledField;
        
        private bool sellerThirdPartyCheckoutDisabledFieldSpecified;
        
        private DispatchCutoffTimePreferencesType dispatchCutoffTimePreferenceField;
        
        private bool globalShippingProgramListingPreferenceField;
        
        private bool globalShippingProgramListingPreferenceFieldSpecified;
        
        private bool overrideGSPserviceWithIntlServiceField;
        
        private bool overrideGSPserviceWithIntlServiceFieldSpecified;
        
        private bool outOfStockControlPreferenceField;
        
        private bool outOfStockControlPreferenceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BidderNoticePreferencesType BidderNoticePreferences
        {
            get
            {
                return this.bidderNoticePreferencesField;
            }
            set
            {
                this.bidderNoticePreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CombinedPaymentPreferencesType CombinedPaymentPreferences
        {
            get
            {
                return this.combinedPaymentPreferencesField;
            }
            set
            {
                this.combinedPaymentPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CrossPromotionPreferencesType CrossPromotionPreferences
        {
            get
            {
                return this.crossPromotionPreferencesField;
            }
            set
            {
                this.crossPromotionPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerPaymentPreferencesType SellerPaymentPreferences
        {
            get
            {
                return this.sellerPaymentPreferencesField;
            }
            set
            {
                this.sellerPaymentPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences
        {
            get
            {
                return this.sellerFavoriteItemPreferencesField;
            }
            set
            {
                this.sellerFavoriteItemPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences
        {
            get
            {
                return this.endOfAuctionEmailPreferencesField;
            }
            set
            {
                this.endOfAuctionEmailPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EmailShipmentTrackingNumberPreference
        {
            get
            {
                return this.emailShipmentTrackingNumberPreferenceField;
            }
            set
            {
                this.emailShipmentTrackingNumberPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailShipmentTrackingNumberPreferenceSpecified
        {
            get
            {
                return this.emailShipmentTrackingNumberPreferenceFieldSpecified;
            }
            set
            {
                this.emailShipmentTrackingNumberPreferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool RequiredShipPhoneNumberPreference
        {
            get
            {
                return this.requiredShipPhoneNumberPreferenceField;
            }
            set
            {
                this.requiredShipPhoneNumberPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredShipPhoneNumberPreferenceSpecified
        {
            get
            {
                return this.requiredShipPhoneNumberPreferenceFieldSpecified;
            }
            set
            {
                this.requiredShipPhoneNumberPreferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences
        {
            get
            {
                return this.unpaidItemAssistancePreferencesField;
            }
            set
            {
                this.unpaidItemAssistancePreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences
        {
            get
            {
                return this.purchaseReminderEmailPreferencesField;
            }
            set
            {
                this.purchaseReminderEmailPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SellerThirdPartyCheckoutDisabled
        {
            get
            {
                return this.sellerThirdPartyCheckoutDisabledField;
            }
            set
            {
                this.sellerThirdPartyCheckoutDisabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerThirdPartyCheckoutDisabledSpecified
        {
            get
            {
                return this.sellerThirdPartyCheckoutDisabledFieldSpecified;
            }
            set
            {
                this.sellerThirdPartyCheckoutDisabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DispatchCutoffTimePreferencesType DispatchCutoffTimePreference
        {
            get
            {
                return this.dispatchCutoffTimePreferenceField;
            }
            set
            {
                this.dispatchCutoffTimePreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool GlobalShippingProgramListingPreference
        {
            get
            {
                return this.globalShippingProgramListingPreferenceField;
            }
            set
            {
                this.globalShippingProgramListingPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GlobalShippingProgramListingPreferenceSpecified
        {
            get
            {
                return this.globalShippingProgramListingPreferenceFieldSpecified;
            }
            set
            {
                this.globalShippingProgramListingPreferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool OverrideGSPserviceWithIntlService
        {
            get
            {
                return this.overrideGSPserviceWithIntlServiceField;
            }
            set
            {
                this.overrideGSPserviceWithIntlServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverrideGSPserviceWithIntlServiceSpecified
        {
            get
            {
                return this.overrideGSPserviceWithIntlServiceFieldSpecified;
            }
            set
            {
                this.overrideGSPserviceWithIntlServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool OutOfStockControlPreference
        {
            get
            {
                return this.outOfStockControlPreferenceField;
            }
            set
            {
                this.outOfStockControlPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutOfStockControlPreferenceSpecified
        {
            get
            {
                return this.outOfStockControlPreferenceFieldSpecified;
            }
            set
            {
                this.outOfStockControlPreferenceFieldSpecified = value;
            }
        }
    }
