    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingDetailsType
    {
        
        private bool allowPaymentEditField;
        
        private bool allowPaymentEditFieldSpecified;
        
        private bool applyShippingDiscountField;
        
        private bool applyShippingDiscountFieldSpecified;
        
        private bool globalShippingField;
        
        private bool globalShippingFieldSpecified;
        
        private CalculatedShippingRateType calculatedShippingRateField;
        
        private bool changePaymentInstructionsField;
        
        private bool changePaymentInstructionsFieldSpecified;
        
        private bool insuranceWantedField;
        
        private bool insuranceWantedFieldSpecified;
        
        private bool paymentEditedField;
        
        private bool paymentEditedFieldSpecified;
        
        private string paymentInstructionsField;
        
        private SalesTaxType salesTaxField;
        
        private string shippingRateErrorMessageField;
        
        private ShippingRateTypeCodeType shippingRateTypeField;
        
        private bool shippingRateTypeFieldSpecified;
        
        private ShippingServiceOptionsType[] shippingServiceOptionsField;
        
        private InternationalShippingServiceOptionsType[] internationalShippingServiceOptionField;
        
        private ShippingTypeCodeType shippingTypeField;
        
        private bool shippingTypeFieldSpecified;
        
        private int sellingManagerSalesRecordNumberField;
        
        private bool sellingManagerSalesRecordNumberFieldSpecified;
        
        private bool thirdPartyCheckoutField;
        
        private bool thirdPartyCheckoutFieldSpecified;
        
        private TaxJurisdictionType[] taxTableField;
        
        private bool getItFastField;
        
        private bool getItFastFieldSpecified;
        
        private string shippingServiceUsedField;
        
        private AmountType defaultShippingCostField;
        
        private string shippingDiscountProfileIDField;
        
        private FlatShippingDiscountType flatShippingDiscountField;
        
        private CalculatedShippingDiscountType calculatedShippingDiscountField;
        
        private bool promotionalShippingDiscountField;
        
        private bool promotionalShippingDiscountFieldSpecified;
        
        private string internationalShippingDiscountProfileIDField;
        
        private FlatShippingDiscountType internationalFlatShippingDiscountField;
        
        private CalculatedShippingDiscountType internationalCalculatedShippingDiscountField;
        
        private bool internationalPromotionalShippingDiscountField;
        
        private bool internationalPromotionalShippingDiscountFieldSpecified;
        
        private PromotionalShippingDiscountDetailsType promotionalShippingDiscountDetailsField;
        
        private AmountType cODCostField;
        
        private string[] excludeShipToLocationField;
        
        private bool sellerExcludeShipToLocationsPreferenceField;
        
        private bool sellerExcludeShipToLocationsPreferenceFieldSpecified;
        
        private ShipmentTrackingDetailsType[] shipmentTrackingDetailsField;
        
        private RateTableDetailsType rateTableDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AllowPaymentEdit
        {
            get
            {
                return this.allowPaymentEditField;
            }
            set
            {
                this.allowPaymentEditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowPaymentEditSpecified
        {
            get
            {
                return this.allowPaymentEditFieldSpecified;
            }
            set
            {
                this.allowPaymentEditFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ApplyShippingDiscount
        {
            get
            {
                return this.applyShippingDiscountField;
            }
            set
            {
                this.applyShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplyShippingDiscountSpecified
        {
            get
            {
                return this.applyShippingDiscountFieldSpecified;
            }
            set
            {
                this.applyShippingDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool GlobalShipping
        {
            get
            {
                return this.globalShippingField;
            }
            set
            {
                this.globalShippingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GlobalShippingSpecified
        {
            get
            {
                return this.globalShippingFieldSpecified;
            }
            set
            {
                this.globalShippingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingRateType CalculatedShippingRate
        {
            get
            {
                return this.calculatedShippingRateField;
            }
            set
            {
                this.calculatedShippingRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ChangePaymentInstructions
        {
            get
            {
                return this.changePaymentInstructionsField;
            }
            set
            {
                this.changePaymentInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangePaymentInstructionsSpecified
        {
            get
            {
                return this.changePaymentInstructionsFieldSpecified;
            }
            set
            {
                this.changePaymentInstructionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool InsuranceWanted
        {
            get
            {
                return this.insuranceWantedField;
            }
            set
            {
                this.insuranceWantedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InsuranceWantedSpecified
        {
            get
            {
                return this.insuranceWantedFieldSpecified;
            }
            set
            {
                this.insuranceWantedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PaymentEdited
        {
            get
            {
                return this.paymentEditedField;
            }
            set
            {
                this.paymentEditedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentEditedSpecified
        {
            get
            {
                return this.paymentEditedFieldSpecified;
            }
            set
            {
                this.paymentEditedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PaymentInstructions
        {
            get
            {
                return this.paymentInstructionsField;
            }
            set
            {
                this.paymentInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SalesTaxType SalesTax
        {
            get
            {
                return this.salesTaxField;
            }
            set
            {
                this.salesTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShippingRateErrorMessage
        {
            get
            {
                return this.shippingRateErrorMessageField;
            }
            set
            {
                this.shippingRateErrorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingRateTypeCodeType ShippingRateType
        {
            get
            {
                return this.shippingRateTypeField;
            }
            set
            {
                this.shippingRateTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingRateTypeSpecified
        {
            get
            {
                return this.shippingRateTypeFieldSpecified;
            }
            set
            {
                this.shippingRateTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingServiceOptions" )]
        public ShippingServiceOptionsType[] ShippingServiceOptions
        {
            get
            {
                return this.shippingServiceOptionsField;
            }
            set
            {
                this.shippingServiceOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternationalShippingServiceOption" )]
        public InternationalShippingServiceOptionsType[] InternationalShippingServiceOption
        {
            get
            {
                return this.internationalShippingServiceOptionField;
            }
            set
            {
                this.internationalShippingServiceOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingTypeCodeType ShippingType
        {
            get
            {
                return this.shippingTypeField;
            }
            set
            {
                this.shippingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingTypeSpecified
        {
            get
            {
                return this.shippingTypeFieldSpecified;
            }
            set
            {
                this.shippingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int SellingManagerSalesRecordNumber
        {
            get
            {
                return this.sellingManagerSalesRecordNumberField;
            }
            set
            {
                this.sellingManagerSalesRecordNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellingManagerSalesRecordNumberSpecified
        {
            get
            {
                return this.sellingManagerSalesRecordNumberFieldSpecified;
            }
            set
            {
                this.sellingManagerSalesRecordNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ThirdPartyCheckout
        {
            get
            {
                return this.thirdPartyCheckoutField;
            }
            set
            {
                this.thirdPartyCheckoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThirdPartyCheckoutSpecified
        {
            get
            {
                return this.thirdPartyCheckoutFieldSpecified;
            }
            set
            {
                this.thirdPartyCheckoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxJurisdiction", IsNullable=false)]
        public TaxJurisdictionType[] TaxTable
        {
            get
            {
                return this.taxTableField;
            }
            set
            {
                this.taxTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool GetItFast
        {
            get
            {
                return this.getItFastField;
            }
            set
            {
                this.getItFastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GetItFastSpecified
        {
            get
            {
                return this.getItFastFieldSpecified;
            }
            set
            {
                this.getItFastFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingServiceUsed
        {
            get
            {
                return this.shippingServiceUsedField;
            }
            set
            {
                this.shippingServiceUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType DefaultShippingCost
        {
            get
            {
                return this.defaultShippingCostField;
            }
            set
            {
                this.defaultShippingCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShippingDiscountProfileID
        {
            get
            {
                return this.shippingDiscountProfileIDField;
            }
            set
            {
                this.shippingDiscountProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FlatShippingDiscountType FlatShippingDiscount
        {
            get
            {
                return this.flatShippingDiscountField;
            }
            set
            {
                this.flatShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingDiscountType CalculatedShippingDiscount
        {
            get
            {
                return this.calculatedShippingDiscountField;
            }
            set
            {
                this.calculatedShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PromotionalShippingDiscount
        {
            get
            {
                return this.promotionalShippingDiscountField;
            }
            set
            {
                this.promotionalShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalShippingDiscountSpecified
        {
            get
            {
                return this.promotionalShippingDiscountFieldSpecified;
            }
            set
            {
                this.promotionalShippingDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalShippingDiscountProfileID
        {
            get
            {
                return this.internationalShippingDiscountProfileIDField;
            }
            set
            {
                this.internationalShippingDiscountProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FlatShippingDiscountType InternationalFlatShippingDiscount
        {
            get
            {
                return this.internationalFlatShippingDiscountField;
            }
            set
            {
                this.internationalFlatShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingDiscountType InternationalCalculatedShippingDiscount
        {
            get
            {
                return this.internationalCalculatedShippingDiscountField;
            }
            set
            {
                this.internationalCalculatedShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool InternationalPromotionalShippingDiscount
        {
            get
            {
                return this.internationalPromotionalShippingDiscountField;
            }
            set
            {
                this.internationalPromotionalShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InternationalPromotionalShippingDiscountSpecified
        {
            get
            {
                return this.internationalPromotionalShippingDiscountFieldSpecified;
            }
            set
            {
                this.internationalPromotionalShippingDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
        {
            get
            {
                return this.promotionalShippingDiscountDetailsField;
            }
            set
            {
                this.promotionalShippingDiscountDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CODCost
        {
            get
            {
                return this.cODCostField;
            }
            set
            {
                this.cODCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExcludeShipToLocation" )]
        public string[] ExcludeShipToLocation
        {
            get
            {
                return this.excludeShipToLocationField;
            }
            set
            {
                this.excludeShipToLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SellerExcludeShipToLocationsPreference
        {
            get
            {
                return this.sellerExcludeShipToLocationsPreferenceField;
            }
            set
            {
                this.sellerExcludeShipToLocationsPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerExcludeShipToLocationsPreferenceSpecified
        {
            get
            {
                return this.sellerExcludeShipToLocationsPreferenceFieldSpecified;
            }
            set
            {
                this.sellerExcludeShipToLocationsPreferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentTrackingDetails" )]
        public ShipmentTrackingDetailsType[] ShipmentTrackingDetails
        {
            get
            {
                return this.shipmentTrackingDetailsField;
            }
            set
            {
                this.shipmentTrackingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RateTableDetailsType RateTableDetails
        {
            get
            {
                return this.rateTableDetailsField;
            }
            set
            {
                this.rateTableDetailsField = value;
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
