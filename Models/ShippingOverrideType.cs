    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingOverrideType
    {
        
        private ShippingServiceCostOverrideListType shippingServiceCostOverrideListField;
        
        private int dispatchTimeMaxOverrideField;
        
        private bool dispatchTimeMaxOverrideFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingServiceCostOverrideListType ShippingServiceCostOverrideList
        {
            get
            {
                return this.shippingServiceCostOverrideListField;
            }
            set
            {
                this.shippingServiceCostOverrideListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DispatchTimeMaxOverride
        {
            get
            {
                return this.dispatchTimeMaxOverrideField;
            }
            set
            {
                this.dispatchTimeMaxOverrideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DispatchTimeMaxOverrideSpecified
        {
            get
            {
                return this.dispatchTimeMaxOverrideFieldSpecified;
            }
            set
            {
                this.dispatchTimeMaxOverrideFieldSpecified = value;
            }
        }
    }
