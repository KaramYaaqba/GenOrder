    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingServiceCostOverrideType
    {
        
        private int shippingServicePriorityField;
        
        private bool shippingServicePriorityFieldSpecified;
        
        private ShippingServiceType shippingServiceTypeField;
        
        private bool shippingServiceTypeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        private AmountType shippingServiceCostField;
        
        private AmountType shippingServiceAdditionalCostField;
        
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
        public ShippingServiceType ShippingServiceType
        {
            get
            {
                return this.shippingServiceTypeField;
            }
            set
            {
                this.shippingServiceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingServiceTypeSpecified
        {
            get
            {
                return this.shippingServiceTypeFieldSpecified;
            }
            set
            {
                this.shippingServiceTypeFieldSpecified = value;
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
    }
