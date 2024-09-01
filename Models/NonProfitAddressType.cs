    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NonProfitAddressType
    {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string cityField;
        
        private string stateField;
        
        private string zipCodeField;
        
        private decimal latitudeField;
        
        private bool latitudeFieldSpecified;
        
        private decimal longitudeField;
        
        private bool longitudeFieldSpecified;
        
        private AddressTypeCodeType addressTypeField;
        
        private bool addressTypeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public decimal Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public decimal Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressTypeCodeType AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressTypeSpecified
        {
            get
            {
                return this.addressTypeFieldSpecified;
            }
            set
            {
                this.addressTypeFieldSpecified = value;
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
