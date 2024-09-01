    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddDisputeResponseRequestType : AbstractRequestType
    {
        
        private string disputeIDField;
        
        private string messageTextField;
        
        private DisputeActivityCodeType disputeActivityField;
        
        private bool disputeActivityFieldSpecified;
        
        private string shippingCarrierUsedField;
        
        private string shipmentTrackNumberField;
        
        private System.DateTime shippingTimeField;
        
        private bool shippingTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DisputeID
        {
            get
            {
                return this.disputeIDField;
            }
            set
            {
                this.disputeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MessageText
        {
            get
            {
                return this.messageTextField;
            }
            set
            {
                this.messageTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeActivityCodeType DisputeActivity
        {
            get
            {
                return this.disputeActivityField;
            }
            set
            {
                this.disputeActivityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeActivitySpecified
        {
            get
            {
                return this.disputeActivityFieldSpecified;
            }
            set
            {
                this.disputeActivityFieldSpecified = value;
            }
        }
        
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
        public string ShipmentTrackNumber
        {
            get
            {
                return this.shipmentTrackNumberField;
            }
            set
            {
                this.shipmentTrackNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ShippingTime
        {
            get
            {
                return this.shippingTimeField;
            }
            set
            {
                this.shippingTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingTimeSpecified
        {
            get
            {
                return this.shippingTimeFieldSpecified;
            }
            set
            {
                this.shippingTimeFieldSpecified = value;
            }
        }
    }
