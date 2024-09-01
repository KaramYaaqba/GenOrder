    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShipPackageDetailsType
    {
        
        private MeasurementSystemCodeType measurementUnitField;
        
        private bool measurementUnitFieldSpecified;
        
        private MeasureType packageDepthField;
        
        private MeasureType packageLengthField;
        
        private MeasureType packageWidthField;
        
        private bool shippingIrregularField;
        
        private bool shippingIrregularFieldSpecified;
        
        private ShippingPackageCodeType shippingPackageField;
        
        private bool shippingPackageFieldSpecified;
        
        private MeasureType weightMajorField;
        
        private MeasureType weightMinorField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasurementSystemCodeType MeasurementUnit
        {
            get
            {
                return this.measurementUnitField;
            }
            set
            {
                this.measurementUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeasurementUnitSpecified
        {
            get
            {
                return this.measurementUnitFieldSpecified;
            }
            set
            {
                this.measurementUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageDepth
        {
            get
            {
                return this.packageDepthField;
            }
            set
            {
                this.packageDepthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageLength
        {
            get
            {
                return this.packageLengthField;
            }
            set
            {
                this.packageLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageWidth
        {
            get
            {
                return this.packageWidthField;
            }
            set
            {
                this.packageWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShippingIrregular
        {
            get
            {
                return this.shippingIrregularField;
            }
            set
            {
                this.shippingIrregularField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingIrregularSpecified
        {
            get
            {
                return this.shippingIrregularFieldSpecified;
            }
            set
            {
                this.shippingIrregularFieldSpecified = value;
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
        public MeasureType WeightMajor
        {
            get
            {
                return this.weightMajorField;
            }
            set
            {
                this.weightMajorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType WeightMinor
        {
            get
            {
                return this.weightMinorField;
            }
            set
            {
                this.weightMinorField = value;
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
