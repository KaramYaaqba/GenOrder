    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ApplicationDeliveryPreferencesType
    {
        
        private string applicationURLField;
        
        private EnableCodeType applicationEnableField;
        
        private bool applicationEnableFieldSpecified;
        
        private string alertEmailField;
        
        private EnableCodeType alertEnableField;
        
        private bool alertEnableFieldSpecified;
        
        private NotificationPayloadTypeCodeType notificationPayloadTypeField;
        
        private bool notificationPayloadTypeFieldSpecified;
        
        private DeviceTypeCodeType deviceTypeField;
        
        private bool deviceTypeFieldSpecified;
        
        private string payloadVersionField;
        
        private DeliveryURLDetailType[] deliveryURLDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ApplicationURL
        {
            get
            {
                return this.applicationURLField;
            }
            set
            {
                this.applicationURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public EnableCodeType ApplicationEnable
        {
            get
            {
                return this.applicationEnableField;
            }
            set
            {
                this.applicationEnableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationEnableSpecified
        {
            get
            {
                return this.applicationEnableFieldSpecified;
            }
            set
            {
                this.applicationEnableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string AlertEmail
        {
            get
            {
                return this.alertEmailField;
            }
            set
            {
                this.alertEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public EnableCodeType AlertEnable
        {
            get
            {
                return this.alertEnableField;
            }
            set
            {
                this.alertEnableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlertEnableSpecified
        {
            get
            {
                return this.alertEnableFieldSpecified;
            }
            set
            {
                this.alertEnableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationPayloadTypeCodeType NotificationPayloadType
        {
            get
            {
                return this.notificationPayloadTypeField;
            }
            set
            {
                this.notificationPayloadTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotificationPayloadTypeSpecified
        {
            get
            {
                return this.notificationPayloadTypeFieldSpecified;
            }
            set
            {
                this.notificationPayloadTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DeviceTypeCodeType DeviceType
        {
            get
            {
                return this.deviceTypeField;
            }
            set
            {
                this.deviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeviceTypeSpecified
        {
            get
            {
                return this.deviceTypeFieldSpecified;
            }
            set
            {
                this.deviceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PayloadVersion
        {
            get
            {
                return this.payloadVersionField;
            }
            set
            {
                this.payloadVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryURLDetails" )]
        public DeliveryURLDetailType[] DeliveryURLDetails
        {
            get
            {
                return this.deliveryURLDetailsField;
            }
            set
            {
                this.deliveryURLDetailsField = value;
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
