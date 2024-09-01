    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemShippingRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private int quantitySoldField;
        
        private bool quantitySoldFieldSpecified;
        
        private string destinationPostalCodeField;
        
        private CountryCodeType destinationCountryCodeField;
        
        private bool destinationCountryCodeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantitySold
        {
            get
            {
                return this.quantitySoldField;
            }
            set
            {
                this.quantitySoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySoldSpecified
        {
            get
            {
                return this.quantitySoldFieldSpecified;
            }
            set
            {
                this.quantitySoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DestinationPostalCode
        {
            get
            {
                return this.destinationPostalCodeField;
            }
            set
            {
                this.destinationPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType DestinationCountryCode
        {
            get
            {
                return this.destinationCountryCodeField;
            }
            set
            {
                this.destinationCountryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DestinationCountryCodeSpecified
        {
            get
            {
                return this.destinationCountryCodeFieldSpecified;
            }
            set
            {
                this.destinationCountryCodeFieldSpecified = value;
            }
        }
    }
