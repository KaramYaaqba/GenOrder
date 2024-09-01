    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class InternationalShippingServiceOptionsType
    {
        
        private string shippingServiceField;
        
        private AmountType shippingServiceCostField;
        
        private AmountType shippingServiceAdditionalCostField;
        
        private int shippingServicePriorityField;
        
        private bool shippingServicePriorityFieldSpecified;
        
        private string[] shipToLocationField;
        
        private AmountType shippingInsuranceCostField;
        
        private AmountType importChargeField;
        
        private System.DateTime shippingServiceCutOffTimeField;
        
        private bool shippingServiceCutOffTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("ShipToLocation" )]
        public string[] ShipToLocation
        {
            get
            {
                return this.shipToLocationField;
            }
            set
            {
                this.shipToLocationField = value;
            }
        }
        
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
