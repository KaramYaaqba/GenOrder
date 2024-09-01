    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NotificationDetailsType
    {
        
        private string deliveryURLField;
        
        private string referenceIDField;
        
        private System.DateTime expirationTimeField;
        
        private bool expirationTimeFieldSpecified;
        
        private NotificationEventTypeCodeType typeField;
        
        private bool typeFieldSpecified;
        
        private int retriesField;
        
        private bool retriesFieldSpecified;
        
        private NotificationEventStateCodeType deliveryStatusField;
        
        private bool deliveryStatusFieldSpecified;
        
        private System.DateTime nextRetryTimeField;
        
        private bool nextRetryTimeFieldSpecified;
        
        private System.DateTime deliveryTimeField;
        
        private bool deliveryTimeFieldSpecified;
        
        private string errorMessageField;
        
        private string deliveryURLNameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string DeliveryURL
        {
            get
            {
                return this.deliveryURLField;
            }
            set
            {
                this.deliveryURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ExpirationTime
        {
            get
            {
                return this.expirationTimeField;
            }
            set
            {
                this.expirationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationTimeSpecified
        {
            get
            {
                return this.expirationTimeFieldSpecified;
            }
            set
            {
                this.expirationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationEventTypeCodeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Retries
        {
            get
            {
                return this.retriesField;
            }
            set
            {
                this.retriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetriesSpecified
        {
            get
            {
                return this.retriesFieldSpecified;
            }
            set
            {
                this.retriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationEventStateCodeType DeliveryStatus
        {
            get
            {
                return this.deliveryStatusField;
            }
            set
            {
                this.deliveryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryStatusSpecified
        {
            get
            {
                return this.deliveryStatusFieldSpecified;
            }
            set
            {
                this.deliveryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime NextRetryTime
        {
            get
            {
                return this.nextRetryTimeField;
            }
            set
            {
                this.nextRetryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NextRetryTimeSpecified
        {
            get
            {
                return this.nextRetryTimeFieldSpecified;
            }
            set
            {
                this.nextRetryTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime DeliveryTime
        {
            get
            {
                return this.deliveryTimeField;
            }
            set
            {
                this.deliveryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryTimeSpecified
        {
            get
            {
                return this.deliveryTimeFieldSpecified;
            }
            set
            {
                this.deliveryTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DeliveryURLName
        {
            get
            {
                return this.deliveryURLNameField;
            }
            set
            {
                this.deliveryURLNameField = value;
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
