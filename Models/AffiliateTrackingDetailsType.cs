    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AffiliateTrackingDetailsType
    {
        
        private string trackingIDField;
        
        private string trackingPartnerCodeField;
        
        private ApplicationDeviceTypeCodeType applicationDeviceTypeField;
        
        private bool applicationDeviceTypeFieldSpecified;
        
        private string affiliateUserIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TrackingID
        {
            get
            {
                return this.trackingIDField;
            }
            set
            {
                this.trackingIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TrackingPartnerCode
        {
            get
            {
                return this.trackingPartnerCodeField;
            }
            set
            {
                this.trackingPartnerCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ApplicationDeviceTypeCodeType ApplicationDeviceType
        {
            get
            {
                return this.applicationDeviceTypeField;
            }
            set
            {
                this.applicationDeviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicationDeviceTypeSpecified
        {
            get
            {
                return this.applicationDeviceTypeFieldSpecified;
            }
            set
            {
                this.applicationDeviceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AffiliateUserID
        {
            get
            {
                return this.affiliateUserIDField;
            }
            set
            {
                this.affiliateUserIDField = value;
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
