    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingServiceDetailsType
    {
        
        private string descriptionField;
        
        private bool expeditedServiceField;
        
        private bool expeditedServiceFieldSpecified;
        
        private bool internationalServiceField;
        
        private bool internationalServiceFieldSpecified;
        
        private string shippingServiceField;
        
        private int shippingServiceIDField;
        
        private bool shippingServiceIDFieldSpecified;
        
        private int shippingTimeMaxField;
        
        private bool shippingTimeMaxFieldSpecified;
        
        private int shippingTimeMinField;
        
        private bool shippingTimeMinFieldSpecified;
        
        private ShippingServiceCodeType shippingServiceCodeField;
        
        private bool shippingServiceCodeFieldSpecified;
        
        private ShippingTypeCodeType[] serviceTypeField;
        
        private ShippingPackageCodeType[] shippingPackageField;
        
        private bool dimensionsRequiredField;
        
        private bool dimensionsRequiredFieldSpecified;
        
        private bool validForSellingFlowField;
        
        private bool validForSellingFlowFieldSpecified;
        
        private bool surchargeApplicableField;
        
        private bool surchargeApplicableFieldSpecified;
        
        private ShippingCarrierCodeType[] shippingCarrierField;
        
        private bool cODServiceField;
        
        private bool cODServiceFieldSpecified;
        
        private AnnouncementMessageType[] deprecationDetailsField;
        
        private int mappedToShippingServiceIDField;
        
        private bool mappedToShippingServiceIDFieldSpecified;
        
        private string costGroupFlatField;
        
        private ShippingServicePackageDetailsType[] shippingServicePackageDetailsField;
        
        private bool weightRequiredField;
        
        private bool weightRequiredFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private string shippingCategoryField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExpeditedService
        {
            get
            {
                return this.expeditedServiceField;
            }
            set
            {
                this.expeditedServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpeditedServiceSpecified
        {
            get
            {
                return this.expeditedServiceFieldSpecified;
            }
            set
            {
                this.expeditedServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool InternationalService
        {
            get
            {
                return this.internationalServiceField;
            }
            set
            {
                this.internationalServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InternationalServiceSpecified
        {
            get
            {
                return this.internationalServiceFieldSpecified;
            }
            set
            {
                this.internationalServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingService
        {
            get
            {
                return this.shippingServiceField;
            }
            set
            {
                this.shippingServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ShippingServiceID
        {
            get
            {
                return this.shippingServiceIDField;
            }
            set
            {
                this.shippingServiceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingServiceIDSpecified
        {
            get
            {
                return this.shippingServiceIDFieldSpecified;
            }
            set
            {
                this.shippingServiceIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ShippingTimeMax
        {
            get
            {
                return this.shippingTimeMaxField;
            }
            set
            {
                this.shippingTimeMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingTimeMaxSpecified
        {
            get
            {
                return this.shippingTimeMaxFieldSpecified;
            }
            set
            {
                this.shippingTimeMaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ShippingTimeMin
        {
            get
            {
                return this.shippingTimeMinField;
            }
            set
            {
                this.shippingTimeMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingTimeMinSpecified
        {
            get
            {
                return this.shippingTimeMinFieldSpecified;
            }
            set
            {
                this.shippingTimeMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingServiceCodeType ShippingServiceCode
        {
            get
            {
                return this.shippingServiceCodeField;
            }
            set
            {
                this.shippingServiceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingServiceCodeSpecified
        {
            get
            {
                return this.shippingServiceCodeFieldSpecified;
            }
            set
            {
                this.shippingServiceCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceType" )]
        public ShippingTypeCodeType[] ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingPackage" )]
        public ShippingPackageCodeType[] ShippingPackage
        {
            get
            {
                return this.shippingPackageField;
            }
            set
            {
                this.shippingPackageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DimensionsRequired
        {
            get
            {
                return this.dimensionsRequiredField;
            }
            set
            {
                this.dimensionsRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionsRequiredSpecified
        {
            get
            {
                return this.dimensionsRequiredFieldSpecified;
            }
            set
            {
                this.dimensionsRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ValidForSellingFlow
        {
            get
            {
                return this.validForSellingFlowField;
            }
            set
            {
                this.validForSellingFlowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidForSellingFlowSpecified
        {
            get
            {
                return this.validForSellingFlowFieldSpecified;
            }
            set
            {
                this.validForSellingFlowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SurchargeApplicable
        {
            get
            {
                return this.surchargeApplicableField;
            }
            set
            {
                this.surchargeApplicableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurchargeApplicableSpecified
        {
            get
            {
                return this.surchargeApplicableFieldSpecified;
            }
            set
            {
                this.surchargeApplicableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingCarrier" )]
        public ShippingCarrierCodeType[] ShippingCarrier
        {
            get
            {
                return this.shippingCarrierField;
            }
            set
            {
                this.shippingCarrierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CODService
        {
            get
            {
                return this.cODServiceField;
            }
            set
            {
                this.cODServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CODServiceSpecified
        {
            get
            {
                return this.cODServiceFieldSpecified;
            }
            set
            {
                this.cODServiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeprecationDetails" )]
        public AnnouncementMessageType[] DeprecationDetails
        {
            get
            {
                return this.deprecationDetailsField;
            }
            set
            {
                this.deprecationDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MappedToShippingServiceID
        {
            get
            {
                return this.mappedToShippingServiceIDField;
            }
            set
            {
                this.mappedToShippingServiceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MappedToShippingServiceIDSpecified
        {
            get
            {
                return this.mappedToShippingServiceIDFieldSpecified;
            }
            set
            {
                this.mappedToShippingServiceIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string CostGroupFlat
        {
            get
            {
                return this.costGroupFlatField;
            }
            set
            {
                this.costGroupFlatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingServicePackageDetails" )]
        public ShippingServicePackageDetailsType[] ShippingServicePackageDetails
        {
            get
            {
                return this.shippingServicePackageDetailsField;
            }
            set
            {
                this.shippingServicePackageDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool WeightRequired
        {
            get
            {
                return this.weightRequiredField;
            }
            set
            {
                this.weightRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightRequiredSpecified
        {
            get
            {
                return this.weightRequiredFieldSpecified;
            }
            set
            {
                this.weightRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingCategory
        {
            get
            {
                return this.shippingCategoryField;
            }
            set
            {
                this.shippingCategoryField = value;
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
