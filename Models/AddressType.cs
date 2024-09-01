    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddressType
    {
        
        private string nameField;
        
        private string streetField;
        
        private string street1Field;
        
        private string street2Field;
        
        private string cityNameField;
        
        private string countyField;
        
        private string stateOrProvinceField;
        
        private CountryCodeType countryField;
        
        private bool countryFieldSpecified;
        
        private string countryNameField;
        
        private string phoneField;
        
        private CountryCodeType phoneCountryCodeField;
        
        private bool phoneCountryCodeFieldSpecified;
        
        private string phoneCountryPrefixField;
        
        private string phoneAreaOrCityCodeField;
        
        private string phoneLocalNumberField;
        
        private string postalCodeField;
        
        private string addressIDField;
        
        private AddressOwnerCodeType addressOwnerField;
        
        private bool addressOwnerFieldSpecified;
        
        private AddressStatusCodeType addressStatusField;
        
        private bool addressStatusFieldSpecified;
        
        private string externalAddressIDField;
        
        private string internationalNameField;
        
        private string internationalStateAndCityField;
        
        private string internationalStreetField;
        
        private string companyNameField;
        
        private AddressRecordTypeCodeType addressRecordTypeField;
        
        private bool addressRecordTypeFieldSpecified;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string phone2Field;
        
        private AddressUsageCodeType addressUsageField;
        
        private bool addressUsageFieldSpecified;
        
        private string referenceIDField;
        
        private AddressAttributeType[] addressAttributeField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Name
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Street1
        {
            get
            {
                return this.street1Field;
            }
            set
            {
                this.street1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Street2
        {
            get
            {
                return this.street2Field;
            }
            set
            {
                this.street2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StateOrProvince
        {
            get
            {
                return this.stateOrProvinceField;
            }
            set
            {
                this.stateOrProvinceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountrySpecified
        {
            get
            {
                return this.countryFieldSpecified;
            }
            set
            {
                this.countryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType PhoneCountryCode
        {
            get
            {
                return this.phoneCountryCodeField;
            }
            set
            {
                this.phoneCountryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhoneCountryCodeSpecified
        {
            get
            {
                return this.phoneCountryCodeFieldSpecified;
            }
            set
            {
                this.phoneCountryCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PhoneCountryPrefix
        {
            get
            {
                return this.phoneCountryPrefixField;
            }
            set
            {
                this.phoneCountryPrefixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PhoneAreaOrCityCode
        {
            get
            {
                return this.phoneAreaOrCityCodeField;
            }
            set
            {
                this.phoneAreaOrCityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PhoneLocalNumber
        {
            get
            {
                return this.phoneLocalNumberField;
            }
            set
            {
                this.phoneLocalNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AddressID
        {
            get
            {
                return this.addressIDField;
            }
            set
            {
                this.addressIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressOwnerCodeType AddressOwner
        {
            get
            {
                return this.addressOwnerField;
            }
            set
            {
                this.addressOwnerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressOwnerSpecified
        {
            get
            {
                return this.addressOwnerFieldSpecified;
            }
            set
            {
                this.addressOwnerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressStatusCodeType AddressStatus
        {
            get
            {
                return this.addressStatusField;
            }
            set
            {
                this.addressStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressStatusSpecified
        {
            get
            {
                return this.addressStatusFieldSpecified;
            }
            set
            {
                this.addressStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalAddressID
        {
            get
            {
                return this.externalAddressIDField;
            }
            set
            {
                this.externalAddressIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalName
        {
            get
            {
                return this.internationalNameField;
            }
            set
            {
                this.internationalNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalStateAndCity
        {
            get
            {
                return this.internationalStateAndCityField;
            }
            set
            {
                this.internationalStateAndCityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalStreet
        {
            get
            {
                return this.internationalStreetField;
            }
            set
            {
                this.internationalStreetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressRecordTypeCodeType AddressRecordType
        {
            get
            {
                return this.addressRecordTypeField;
            }
            set
            {
                this.addressRecordTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressRecordTypeSpecified
        {
            get
            {
                return this.addressRecordTypeFieldSpecified;
            }
            set
            {
                this.addressRecordTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Phone2
        {
            get
            {
                return this.phone2Field;
            }
            set
            {
                this.phone2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressUsageCodeType AddressUsage
        {
            get
            {
                return this.addressUsageField;
            }
            set
            {
                this.addressUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressUsageSpecified
        {
            get
            {
                return this.addressUsageFieldSpecified;
            }
            set
            {
                this.addressUsageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressAttribute" )]
        public AddressAttributeType[] AddressAttribute
        {
            get
            {
                return this.addressAttributeField;
            }
            set
            {
                this.addressAttributeField = value;
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
