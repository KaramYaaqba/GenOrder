    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PickupMethodSelectedType
    {
        
        private string pickupMethodField;
        
        private string pickupStoreIDField;
        
        private PickupStatusCodeType pickupStatusField;
        
        private bool pickupStatusFieldSpecified;
        
        private string merchantPickupCodeField;
        
        private System.DateTime pickupFulfillmentTimeField;
        
        private bool pickupFulfillmentTimeFieldSpecified;
        
        private string pickupLocationUUIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string PickupMethod
        {
            get
            {
                return this.pickupMethodField;
            }
            set
            {
                this.pickupMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PickupStoreID
        {
            get
            {
                return this.pickupStoreIDField;
            }
            set
            {
                this.pickupStoreIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PickupStatusCodeType PickupStatus
        {
            get
            {
                return this.pickupStatusField;
            }
            set
            {
                this.pickupStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickupStatusSpecified
        {
            get
            {
                return this.pickupStatusFieldSpecified;
            }
            set
            {
                this.pickupStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MerchantPickupCode
        {
            get
            {
                return this.merchantPickupCodeField;
            }
            set
            {
                this.merchantPickupCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PickupFulfillmentTime
        {
            get
            {
                return this.pickupFulfillmentTimeField;
            }
            set
            {
                this.pickupFulfillmentTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickupFulfillmentTimeSpecified
        {
            get
            {
                return this.pickupFulfillmentTimeFieldSpecified;
            }
            set
            {
                this.pickupFulfillmentTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PickupLocationUUID
        {
            get
            {
                return this.pickupLocationUUIDField;
            }
            set
            {
                this.pickupLocationUUIDField = value;
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
