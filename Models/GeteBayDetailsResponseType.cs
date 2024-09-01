    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GeteBayDetailsResponseType : AbstractResponseType
    {
        
        private CountryDetailsType[] countryDetailsField;
        
        private CurrencyDetailsType[] currencyDetailsField;
        
        private DispatchTimeMaxDetailsType[] dispatchTimeMaxDetailsField;
        
        private PaymentOptionDetailsType[] paymentOptionDetailsField;
        
        private RegionDetailsType[] regionDetailsField;
        
        private ShippingLocationDetailsType[] shippingLocationDetailsField;
        
        private ShippingServiceDetailsType[] shippingServiceDetailsField;
        
        private SiteDetailsType[] siteDetailsField;
        
        private TaxJurisdictionType[] taxJurisdictionField;
        
        private URLDetailsType[] uRLDetailsField;
        
        private TimeZoneDetailsType[] timeZoneDetailsField;
        
        private ItemSpecificDetailsType[] itemSpecificDetailsField;
        
        private UnitOfMeasurementDetailsType[] unitOfMeasurementDetailsField;
        
        private RegionOfOriginDetailsType[] regionOfOriginDetailsField;
        
        private ShippingPackageDetailsType[] shippingPackageDetailsField;
        
        private ShippingCarrierDetailsType[] shippingCarrierDetailsField;
        
        private ReturnPolicyDetailsType returnPolicyDetailsField;
        
        private ReturnPolicyDetailsType internationalReturnPolicyDetailsField;
        
        private ListingStartPriceDetailsType[] listingStartPriceDetailsField;
        
        private SiteBuyerRequirementDetailsType[] buyerRequirementDetailsField;
        
        private ListingFeatureDetailsType[] listingFeatureDetailsField;
        
        private VariationDetailsType variationDetailsField;
        
        private ExcludeShippingLocationDetailsType[] excludeShippingLocationDetailsField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private RecoupmentPolicyDetailsType[] recoupmentPolicyDetailsField;
        
        private ShippingCategoryDetailsType[] shippingCategoryDetailsField;
        
        private ProductDetailsType productDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CountryDetails" )]
        public CountryDetailsType[] CountryDetails
        {
            get
            {
                return this.countryDetailsField;
            }
            set
            {
                this.countryDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrencyDetails" )]
        public CurrencyDetailsType[] CurrencyDetails
        {
            get
            {
                return this.currencyDetailsField;
            }
            set
            {
                this.currencyDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispatchTimeMaxDetails" )]
        public DispatchTimeMaxDetailsType[] DispatchTimeMaxDetails
        {
            get
            {
                return this.dispatchTimeMaxDetailsField;
            }
            set
            {
                this.dispatchTimeMaxDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentOptionDetails" )]
        public PaymentOptionDetailsType[] PaymentOptionDetails
        {
            get
            {
                return this.paymentOptionDetailsField;
            }
            set
            {
                this.paymentOptionDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegionDetails" )]
        public RegionDetailsType[] RegionDetails
        {
            get
            {
                return this.regionDetailsField;
            }
            set
            {
                this.regionDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingLocationDetails" )]
        public ShippingLocationDetailsType[] ShippingLocationDetails
        {
            get
            {
                return this.shippingLocationDetailsField;
            }
            set
            {
                this.shippingLocationDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingServiceDetails" )]
        public ShippingServiceDetailsType[] ShippingServiceDetails
        {
            get
            {
                return this.shippingServiceDetailsField;
            }
            set
            {
                this.shippingServiceDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SiteDetails" )]
        public SiteDetailsType[] SiteDetails
        {
            get
            {
                return this.siteDetailsField;
            }
            set
            {
                this.siteDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxJurisdiction" )]
        public TaxJurisdictionType[] TaxJurisdiction
        {
            get
            {
                return this.taxJurisdictionField;
            }
            set
            {
                this.taxJurisdictionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URLDetails" )]
        public URLDetailsType[] URLDetails
        {
            get
            {
                return this.uRLDetailsField;
            }
            set
            {
                this.uRLDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeZoneDetails" )]
        public TimeZoneDetailsType[] TimeZoneDetails
        {
            get
            {
                return this.timeZoneDetailsField;
            }
            set
            {
                this.timeZoneDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecificDetails" )]
        public ItemSpecificDetailsType[] ItemSpecificDetails
        {
            get
            {
                return this.itemSpecificDetailsField;
            }
            set
            {
                this.itemSpecificDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasurementDetails" )]
        public UnitOfMeasurementDetailsType[] UnitOfMeasurementDetails
        {
            get
            {
                return this.unitOfMeasurementDetailsField;
            }
            set
            {
                this.unitOfMeasurementDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegionOfOriginDetails" )]
        public RegionOfOriginDetailsType[] RegionOfOriginDetails
        {
            get
            {
                return this.regionOfOriginDetailsField;
            }
            set
            {
                this.regionOfOriginDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingPackageDetails" )]
        public ShippingPackageDetailsType[] ShippingPackageDetails
        {
            get
            {
                return this.shippingPackageDetailsField;
            }
            set
            {
                this.shippingPackageDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingCarrierDetails" )]
        public ShippingCarrierDetailsType[] ShippingCarrierDetails
        {
            get
            {
                return this.shippingCarrierDetailsField;
            }
            set
            {
                this.shippingCarrierDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ReturnPolicyDetailsType ReturnPolicyDetails
        {
            get
            {
                return this.returnPolicyDetailsField;
            }
            set
            {
                this.returnPolicyDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ReturnPolicyDetailsType InternationalReturnPolicyDetails
        {
            get
            {
                return this.internationalReturnPolicyDetailsField;
            }
            set
            {
                this.internationalReturnPolicyDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListingStartPriceDetails" )]
        public ListingStartPriceDetailsType[] ListingStartPriceDetails
        {
            get
            {
                return this.listingStartPriceDetailsField;
            }
            set
            {
                this.listingStartPriceDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuyerRequirementDetails" )]
        public SiteBuyerRequirementDetailsType[] BuyerRequirementDetails
        {
            get
            {
                return this.buyerRequirementDetailsField;
            }
            set
            {
                this.buyerRequirementDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListingFeatureDetails" )]
        public ListingFeatureDetailsType[] ListingFeatureDetails
        {
            get
            {
                return this.listingFeatureDetailsField;
            }
            set
            {
                this.listingFeatureDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationDetailsType VariationDetails
        {
            get
            {
                return this.variationDetailsField;
            }
            set
            {
                this.variationDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExcludeShippingLocationDetails" )]
        public ExcludeShippingLocationDetailsType[] ExcludeShippingLocationDetails
        {
            get
            {
                return this.excludeShippingLocationDetailsField;
            }
            set
            {
                this.excludeShippingLocationDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecoupmentPolicyDetails" )]
        public RecoupmentPolicyDetailsType[] RecoupmentPolicyDetails
        {
            get
            {
                return this.recoupmentPolicyDetailsField;
            }
            set
            {
                this.recoupmentPolicyDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingCategoryDetails" )]
        public ShippingCategoryDetailsType[] ShippingCategoryDetails
        {
            get
            {
                return this.shippingCategoryDetailsField;
            }
            set
            {
                this.shippingCategoryDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ProductDetailsType ProductDetails
        {
            get
            {
                return this.productDetailsField;
            }
            set
            {
                this.productDetailsField = value;
            }
        }
    }
