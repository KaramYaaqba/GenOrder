    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingPackageDetailsType
    {
        
        private int packageIDField;
        
        private bool packageIDFieldSpecified;
        
        private string descriptionField;
        
        private ShippingPackageCodeType shippingPackageField;
        
        private bool shippingPackageFieldSpecified;
        
        private bool defaultValueField;
        
        private bool defaultValueFieldSpecified;
        
        private bool dimensionsSupportedField;
        
        private bool dimensionsSupportedFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PackageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageIDSpecified
        {
            get
            {
                return this.packageIDFieldSpecified;
            }
            set
            {
                this.packageIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingPackageCodeType ShippingPackage
        {
            get
            {
                return this.shippingPackageField;
            }
            set
            {
                this.shippingPackageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingPackageSpecified
        {
            get
            {
                return this.shippingPackageFieldSpecified;
            }
            set
            {
                this.shippingPackageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultValueSpecified
        {
            get
            {
                return this.defaultValueFieldSpecified;
            }
            set
            {
                this.defaultValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DimensionsSupported
        {
            get
            {
                return this.dimensionsSupportedField;
            }
            set
            {
                this.dimensionsSupportedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionsSupportedSpecified
        {
            get
            {
                return this.dimensionsSupportedFieldSpecified;
            }
            set
            {
                this.dimensionsSupportedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
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
