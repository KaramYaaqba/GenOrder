    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShipmentTrackingDetailsType
    {
        
        private string shippingCarrierUsedField;
        
        private string shipmentTrackingNumberField;
        
        private ShipmentLineItemType shipmentLineItemField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShippingCarrierUsed
        {
            get
            {
                return this.shippingCarrierUsedField;
            }
            set
            {
                this.shippingCarrierUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShipmentTrackingNumber
        {
            get
            {
                return this.shipmentTrackingNumberField;
            }
            set
            {
                this.shipmentTrackingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShipmentLineItemType ShipmentLineItem
        {
            get
            {
                return this.shipmentLineItemField;
            }
            set
            {
                this.shipmentLineItemField = value;
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
