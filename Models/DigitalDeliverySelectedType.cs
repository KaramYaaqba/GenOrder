    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DigitalDeliverySelectedType
    {
        
        private string deliveryMethodField;
        
        private DeliveryStatusType deliveryStatusField;
        
        private DeliveryDetailsType deliveryDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string DeliveryMethod
        {
            get
            {
                return this.deliveryMethodField;
            }
            set
            {
                this.deliveryMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DeliveryStatusType DeliveryStatus
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DeliveryDetailsType DeliveryDetails
        {
            get
            {
                return this.deliveryDetailsField;
            }
            set
            {
                this.deliveryDetailsField = value;
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
