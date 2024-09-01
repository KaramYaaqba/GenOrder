    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingServicePackageDetailsType
    {
        
        private ShippingPackageCodeType nameField;
        
        private bool nameFieldSpecified;
        
        private bool dimensionsRequiredField;
        
        private bool dimensionsRequiredFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingPackageCodeType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSpecified
        {
            get
            {
                return this.nameFieldSpecified;
            }
            set
            {
                this.nameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DimensionsRequired
        {
            get
            {
                return this.dimensionsRequiredField;
            }
            set
            {
                this.dimensionsRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionsRequiredSpecified
        {
            get
            {
                return this.dimensionsRequiredFieldSpecified;
            }
            set
            {
                this.dimensionsRequiredFieldSpecified = value;
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
