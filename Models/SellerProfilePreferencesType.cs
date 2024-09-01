    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerProfilePreferencesType
    {
        
        private bool sellerProfileOptedInField;
        
        private bool sellerProfileOptedInFieldSpecified;
        
        private SupportedSellerProfileType[] supportedSellerProfilesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SellerProfileOptedIn
        {
            get
            {
                return this.sellerProfileOptedInField;
            }
            set
            {
                this.sellerProfileOptedInField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerProfileOptedInSpecified
        {
            get
            {
                return this.sellerProfileOptedInFieldSpecified;
            }
            set
            {
                this.sellerProfileOptedInFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("SupportedSellerProfile", IsNullable=false)]
        public SupportedSellerProfileType[] SupportedSellerProfiles
        {
            get
            {
                return this.supportedSellerProfilesField;
            }
            set
            {
                this.supportedSellerProfilesField = value;
            }
        }
    }
