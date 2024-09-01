    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CalculatedShippingDiscountType
    {
        
        private DiscountNameCodeType discountNameField;
        
        private bool discountNameFieldSpecified;
        
        private DiscountProfileType[] discountProfileField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DiscountNameCodeType DiscountName
        {
            get
            {
                return this.discountNameField;
            }
            set
            {
                this.discountNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountNameSpecified
        {
            get
            {
                return this.discountNameFieldSpecified;
            }
            set
            {
                this.discountNameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscountProfile" )]
        public DiscountProfileType[] DiscountProfile
        {
            get
            {
                return this.discountProfileField;
            }
            set
            {
                this.discountProfileField = value;
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
