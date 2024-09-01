    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SMSSubscriptionType
    {
        
        private string sMSPhoneField;
        
        private SMSSubscriptionUserStatusCodeType userStatusField;
        
        private bool userStatusFieldSpecified;
        
        private WirelessCarrierIDCodeType carrierIDField;
        
        private bool carrierIDFieldSpecified;
        
        private SMSSubscriptionErrorCodeCodeType errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private string itemToUnsubscribeField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SMSPhone
        {
            get
            {
                return this.sMSPhoneField;
            }
            set
            {
                this.sMSPhoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SMSSubscriptionUserStatusCodeType UserStatus
        {
            get
            {
                return this.userStatusField;
            }
            set
            {
                this.userStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserStatusSpecified
        {
            get
            {
                return this.userStatusFieldSpecified;
            }
            set
            {
                this.userStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public WirelessCarrierIDCodeType CarrierID
        {
            get
            {
                return this.carrierIDField;
            }
            set
            {
                this.carrierIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CarrierIDSpecified
        {
            get
            {
                return this.carrierIDFieldSpecified;
            }
            set
            {
                this.carrierIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SMSSubscriptionErrorCodeCodeType ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorCodeSpecified
        {
            get
            {
                return this.errorCodeFieldSpecified;
            }
            set
            {
                this.errorCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemToUnsubscribe
        {
            get
            {
                return this.itemToUnsubscribeField;
            }
            set
            {
                this.itemToUnsubscribeField = value;
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
