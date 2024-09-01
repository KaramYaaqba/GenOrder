    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerShippingProfileType
    {
        
        private long shippingProfileIDField;
        
        private bool shippingProfileIDFieldSpecified;
        
        private string shippingProfileNameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ShippingProfileID
        {
            get
            {
                return this.shippingProfileIDField;
            }
            set
            {
                this.shippingProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingProfileIDSpecified
        {
            get
            {
                return this.shippingProfileIDFieldSpecified;
            }
            set
            {
                this.shippingProfileIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShippingProfileName
        {
            get
            {
                return this.shippingProfileNameField;
            }
            set
            {
                this.shippingProfileNameField = value;
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
