    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetNotificationPreferencesResponseType : AbstractResponseType
    {
        
        private ApplicationDeliveryPreferencesType applicationDeliveryPreferencesField;
        
        private string deliveryURLNameField;
        
        private NotificationEnableType[] userDeliveryPreferenceArrayField;
        
        private NotificationUserDataType userDataField;
        
        private NotificationEventPropertyType[] eventPropertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences
        {
            get
            {
                return this.applicationDeliveryPreferencesField;
            }
            set
            {
                this.applicationDeliveryPreferencesField = value;
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
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NotificationEnable", IsNullable=false)]
        public NotificationEnableType[] UserDeliveryPreferenceArray
        {
            get
            {
                return this.userDeliveryPreferenceArrayField;
            }
            set
            {
                this.userDeliveryPreferenceArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationUserDataType UserData
        {
            get
            {
                return this.userDataField;
            }
            set
            {
                this.userDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventProperty" )]
        public NotificationEventPropertyType[] EventProperty
        {
            get
            {
                return this.eventPropertyField;
            }
            set
            {
                this.eventPropertyField = value;
            }
        }
    }
