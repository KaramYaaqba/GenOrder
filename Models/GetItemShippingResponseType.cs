    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemShippingResponseType : AbstractResponseType
    {
        
        private ShippingDetailsType shippingDetailsField;
        
        private PickupInStoreDetailsType pickUpInStoreDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingDetailsType ShippingDetails
        {
            get
            {
                return this.shippingDetailsField;
            }
            set
            {
                this.shippingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PickupInStoreDetailsType PickUpInStoreDetails
        {
            get
            {
                return this.pickUpInStoreDetailsField;
            }
            set
            {
                this.pickUpInStoreDetailsField = value;
            }
        }
    }
