    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ListingCheckoutRedirectPreferenceType
    {
        
        private string proStoresStoreNameField;
        
        private string sellerThirdPartyUsernameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProStoresStoreName
        {
            get
            {
                return this.proStoresStoreNameField;
            }
            set
            {
                this.proStoresStoreNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerThirdPartyUsername
        {
            get
            {
                return this.sellerThirdPartyUsernameField;
            }
            set
            {
                this.sellerThirdPartyUsernameField = value;
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
