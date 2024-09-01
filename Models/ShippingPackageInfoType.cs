    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingPackageInfoType
    {
        
        private string storeIDField;
        
        private string shippingTrackingEventField;
        
        private System.DateTime scheduledDeliveryTimeMinField;
        
        private bool scheduledDeliveryTimeMinFieldSpecified;
        
        private System.DateTime scheduledDeliveryTimeMaxField;
        
        private bool scheduledDeliveryTimeMaxFieldSpecified;
        
        private System.DateTime actualDeliveryTimeField;
        
        private bool actualDeliveryTimeFieldSpecified;
        
        private System.DateTime estimatedDeliveryTimeMinField;
        
        private bool estimatedDeliveryTimeMinFieldSpecified;
        
        private System.DateTime estimatedDeliveryTimeMaxField;
        
        private bool estimatedDeliveryTimeMaxFieldSpecified;
        
        private System.DateTime handleByTimeField;
        
        private bool handleByTimeFieldSpecified;
        
        private System.DateTime minNativeEstimatedDeliveryTimeField;
        
        private bool minNativeEstimatedDeliveryTimeFieldSpecified;
        
        private System.DateTime maxNativeEstimatedDeliveryTimeField;
        
        private bool maxNativeEstimatedDeliveryTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StoreID
        {
            get
            {
                return this.storeIDField;
            }
            set
            {
                this.storeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingTrackingEvent
        {
            get
            {
                return this.shippingTrackingEventField;
            }
            set
            {
                this.shippingTrackingEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ScheduledDeliveryTimeMin
        {
            get
            {
                return this.scheduledDeliveryTimeMinField;
            }
            set
            {
                this.scheduledDeliveryTimeMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledDeliveryTimeMinSpecified
        {
            get
            {
                return this.scheduledDeliveryTimeMinFieldSpecified;
            }
            set
            {
                this.scheduledDeliveryTimeMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ScheduledDeliveryTimeMax
        {
            get
            {
                return this.scheduledDeliveryTimeMaxField;
            }
            set
            {
                this.scheduledDeliveryTimeMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledDeliveryTimeMaxSpecified
        {
            get
            {
                return this.scheduledDeliveryTimeMaxFieldSpecified;
            }
            set
            {
                this.scheduledDeliveryTimeMaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ActualDeliveryTime
        {
            get
            {
                return this.actualDeliveryTimeField;
            }
            set
            {
                this.actualDeliveryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActualDeliveryTimeSpecified
        {
            get
            {
                return this.actualDeliveryTimeFieldSpecified;
            }
            set
            {
                this.actualDeliveryTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EstimatedDeliveryTimeMin
        {
            get
            {
                return this.estimatedDeliveryTimeMinField;
            }
            set
            {
                this.estimatedDeliveryTimeMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimatedDeliveryTimeMinSpecified
        {
            get
            {
                return this.estimatedDeliveryTimeMinFieldSpecified;
            }
            set
            {
                this.estimatedDeliveryTimeMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EstimatedDeliveryTimeMax
        {
            get
            {
                return this.estimatedDeliveryTimeMaxField;
            }
            set
            {
                this.estimatedDeliveryTimeMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimatedDeliveryTimeMaxSpecified
        {
            get
            {
                return this.estimatedDeliveryTimeMaxFieldSpecified;
            }
            set
            {
                this.estimatedDeliveryTimeMaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime HandleByTime
        {
            get
            {
                return this.handleByTimeField;
            }
            set
            {
                this.handleByTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HandleByTimeSpecified
        {
            get
            {
                return this.handleByTimeFieldSpecified;
            }
            set
            {
                this.handleByTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime MinNativeEstimatedDeliveryTime
        {
            get
            {
                return this.minNativeEstimatedDeliveryTimeField;
            }
            set
            {
                this.minNativeEstimatedDeliveryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinNativeEstimatedDeliveryTimeSpecified
        {
            get
            {
                return this.minNativeEstimatedDeliveryTimeFieldSpecified;
            }
            set
            {
                this.minNativeEstimatedDeliveryTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime MaxNativeEstimatedDeliveryTime
        {
            get
            {
                return this.maxNativeEstimatedDeliveryTimeField;
            }
            set
            {
                this.maxNativeEstimatedDeliveryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxNativeEstimatedDeliveryTimeSpecified
        {
            get
            {
                return this.maxNativeEstimatedDeliveryTimeFieldSpecified;
            }
            set
            {
                this.maxNativeEstimatedDeliveryTimeFieldSpecified = value;
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
