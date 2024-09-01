    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CharityInfoType
    {
        
        private string nameField;
        
        private bool listingNPEmailNotifPrefField;
        
        private bool listingNPEmailNotifPrefFieldSpecified;
        
        private string listingNPEmailField;
        
        private string listingNPContactNameField;
        
        private string missionField;
        
        private string logoURLField;
        
        private CharityStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private string searchableStringField;
        
        private int charityRegionField;
        
        private bool charityRegionFieldSpecified;
        
        private int[] charityDomainField;
        
        private string charityIDField;
        
        private string logoURLSellingField;
        
        private bool displayLogoSellingField;
        
        private bool displayLogoSellingFieldSpecified;
        
        private bool displayNameInCheckoutField;
        
        private bool displayNameInCheckoutFieldSpecified;
        
        private string descriptionField;
        
        private bool showMultipleDonationAmountInCheckoutField;
        
        private bool showMultipleDonationAmountInCheckoutFieldSpecified;
        
        private string externalIDField;
        
        private int popularityIndexField;
        
        private bool popularityIndexFieldSpecified;
        
        private string eINField;
        
        private string nonProfitSecondNameField;
        
        private NonProfitAddressType[] nonProfitAddressField;
        
        private NonProfitSocialAddressType[] nonProfitSocialAddressField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string idField;
        
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
        public bool ListingNPEmailNotifPref
        {
            get
            {
                return this.listingNPEmailNotifPrefField;
            }
            set
            {
                this.listingNPEmailNotifPrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingNPEmailNotifPrefSpecified
        {
            get
            {
                return this.listingNPEmailNotifPrefFieldSpecified;
            }
            set
            {
                this.listingNPEmailNotifPrefFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ListingNPEmail
        {
            get
            {
                return this.listingNPEmailField;
            }
            set
            {
                this.listingNPEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ListingNPContactName
        {
            get
            {
                return this.listingNPContactNameField;
            }
            set
            {
                this.listingNPContactNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Mission
        {
            get
            {
                return this.missionField;
            }
            set
            {
                this.missionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string LogoURL
        {
            get
            {
                return this.logoURLField;
            }
            set
            {
                this.logoURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CharityStatusCodeType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SearchableString
        {
            get
            {
                return this.searchableStringField;
            }
            set
            {
                this.searchableStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CharityRegion
        {
            get
            {
                return this.charityRegionField;
            }
            set
            {
                this.charityRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityRegionSpecified
        {
            get
            {
                return this.charityRegionFieldSpecified;
            }
            set
            {
                this.charityRegionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CharityDomain" )]
        public int[] CharityDomain
        {
            get
            {
                return this.charityDomainField;
            }
            set
            {
                this.charityDomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CharityID
        {
            get
            {
                return this.charityIDField;
            }
            set
            {
                this.charityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string LogoURLSelling
        {
            get
            {
                return this.logoURLSellingField;
            }
            set
            {
                this.logoURLSellingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DisplayLogoSelling
        {
            get
            {
                return this.displayLogoSellingField;
            }
            set
            {
                this.displayLogoSellingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayLogoSellingSpecified
        {
            get
            {
                return this.displayLogoSellingFieldSpecified;
            }
            set
            {
                this.displayLogoSellingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DisplayNameInCheckout
        {
            get
            {
                return this.displayNameInCheckoutField;
            }
            set
            {
                this.displayNameInCheckoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayNameInCheckoutSpecified
        {
            get
            {
                return this.displayNameInCheckoutFieldSpecified;
            }
            set
            {
                this.displayNameInCheckoutFieldSpecified = value;
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
        public bool ShowMultipleDonationAmountInCheckout
        {
            get
            {
                return this.showMultipleDonationAmountInCheckoutField;
            }
            set
            {
                this.showMultipleDonationAmountInCheckoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowMultipleDonationAmountInCheckoutSpecified
        {
            get
            {
                return this.showMultipleDonationAmountInCheckoutFieldSpecified;
            }
            set
            {
                this.showMultipleDonationAmountInCheckoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalID
        {
            get
            {
                return this.externalIDField;
            }
            set
            {
                this.externalIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PopularityIndex
        {
            get
            {
                return this.popularityIndexField;
            }
            set
            {
                this.popularityIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PopularityIndexSpecified
        {
            get
            {
                return this.popularityIndexFieldSpecified;
            }
            set
            {
                this.popularityIndexFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EIN
        {
            get
            {
                return this.eINField;
            }
            set
            {
                this.eINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NonProfitSecondName
        {
            get
            {
                return this.nonProfitSecondNameField;
            }
            set
            {
                this.nonProfitSecondNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonProfitAddress" )]
        public NonProfitAddressType[] NonProfitAddress
        {
            get
            {
                return this.nonProfitAddressField;
            }
            set
            {
                this.nonProfitAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonProfitSocialAddress" )]
        public NonProfitSocialAddressType[] NonProfitSocialAddress
        {
            get
            {
                return this.nonProfitSocialAddressField;
            }
            set
            {
                this.nonProfitSocialAddressField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
