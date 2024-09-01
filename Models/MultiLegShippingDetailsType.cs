    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MultiLegShippingDetailsType
    {
        
        private MultiLegShipmentType sellerShipmentToLogisticsProviderField;
        
        private MultiLegShipmentType logisticsProviderShipmentToBuyerField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MultiLegShipmentType SellerShipmentToLogisticsProvider
        {
            get
            {
                return this.sellerShipmentToLogisticsProviderField;
            }
            set
            {
                this.sellerShipmentToLogisticsProviderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MultiLegShipmentType LogisticsProviderShipmentToBuyer
        {
            get
            {
                return this.logisticsProviderShipmentToBuyerField;
            }
            set
            {
                this.logisticsProviderShipmentToBuyerField = value;
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
