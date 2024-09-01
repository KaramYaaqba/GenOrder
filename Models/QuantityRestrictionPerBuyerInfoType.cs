    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class QuantityRestrictionPerBuyerInfoType
    {
        
        private int maximumQuantityField;
        
        private bool maximumQuantityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumQuantitySpecified
        {
            get
            {
                return this.maximumQuantityFieldSpecified;
            }
            set
            {
                this.maximumQuantityFieldSpecified = value;
            }
        }
    }
