    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MultiLegShipmentType
    {
        
        private MultiLegShippingServiceType shippingServiceDetailsField;
        
        private AddressType shipToAddressField;
        
        private int shippingTimeMinField;
        
        private bool shippingTimeMinFieldSpecified;
        
        private int shippingTimeMaxField;
        
        private bool shippingTimeMaxFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MultiLegShippingServiceType ShippingServiceDetails
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ShipToAddress
        {
            get
            {
                return this.shipToAddressField;
            }
            set
            {
                this.shipToAddressField = value;
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
