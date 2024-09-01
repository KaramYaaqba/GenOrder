    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingServiceOptionsType
    {
        
        private AmountType shippingInsuranceCostField;
        
        private string shippingServiceField;
        
        private AmountType shippingServiceCostField;
        
        private AmountType shippingServiceAdditionalCostField;
        
        private int shippingServicePriorityField;
        
        private bool shippingServicePriorityFieldSpecified;
        
        private bool expeditedServiceField;
        
        private bool expeditedServiceFieldSpecified;
        
        private int shippingTimeMinField;
        
        private bool shippingTimeMinFieldSpecified;
        
        private int shippingTimeMaxField;
        
        private bool shippingTimeMaxFieldSpecified;
        
        private bool freeShippingField;
        
        private bool freeShippingFieldSpecified;
        
        private bool localPickupField;
        
        private bool localPickupFieldSpecified;
        
        private AmountType importChargeField;
        
        private ShippingPackageInfoType[] shippingPackageInfoField;
        
        private System.DateTime shippingServiceCutOffTimeField;
        
        private bool shippingServiceCutOffTimeFieldSpecified;
        
        private string logisticPlanTypeField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingInsuranceCost
        {
            get
            {
                return this.shippingInsuranceCostField;
            }
            set
            {
                this.shippingInsuranceCostField = value;
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
        public AmountType ShippingServiceCost
        {
            get
            {
                return this.shippingServiceCostField;
            }
            set
            {
                this.shippingServiceCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingServiceAdditionalCost
        {
            get
            {
                return this.shippingServiceAdditionalCostField;
            }
            set
            {
                this.shippingServiceAdditionalCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ShippingServicePriority
        {
            get
            {
                return this.shippingServicePriorityField;
            }
            set
            {
                this.shippingServicePriorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingServicePrioritySpecified
        {
            get
            {
                return this.shippingServicePriorityFieldSpecified;
            }
            set
            {
                this.shippingServicePriorityFieldSpecified = value;
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
        public bool FreeShipping
        {
            get
            {
                return this.freeShippingField;
            }
            set
            {
                this.freeShippingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreeShippingSpecified
        {
            get
            {
                return this.freeShippingFieldSpecified;
            }
            set
            {
                this.freeShippingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool LocalPickup
        {
            get
            {
                return this.localPickupField;
            }
            set
            {
                this.localPickupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalPickupSpecified
        {
            get
            {
                return this.localPickupFieldSpecified;
            }
            set
            {
                this.localPickupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ImportCharge
        {
            get
            {
                return this.importChargeField;
            }
            set
            {
                this.importChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingPackageInfo" )]
        public ShippingPackageInfoType[] ShippingPackageInfo
        {
            get
            {
                return this.shippingPackageInfoField;
            }
            set
            {
                this.shippingPackageInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ShippingServiceCutOffTime
        {
            get
            {
                return this.shippingServiceCutOffTimeField;
            }
            set
            {
                this.shippingServiceCutOffTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingServiceCutOffTimeSpecified
        {
            get
            {
                return this.shippingServiceCutOffTimeFieldSpecified;
            }
            set
            {
                this.shippingServiceCutOffTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string LogisticPlanType
        {
            get
            {
                return this.logisticPlanTypeField;
            }
            set
            {
                this.logisticPlanTypeField = value;
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
