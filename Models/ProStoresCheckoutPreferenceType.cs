    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ProStoresCheckoutPreferenceType
    {
        
        private bool checkoutRedirectProStoresField;
        
        private bool checkoutRedirectProStoresFieldSpecified;
        
        private ProStoresDetailsType proStoresDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CheckoutRedirectProStores
        {
            get
            {
                return this.checkoutRedirectProStoresField;
            }
            set
            {
                this.checkoutRedirectProStoresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckoutRedirectProStoresSpecified
        {
            get
            {
                return this.checkoutRedirectProStoresFieldSpecified;
            }
            set
            {
                this.checkoutRedirectProStoresFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ProStoresDetailsType ProStoresDetails
        {
            get
            {
                return this.proStoresDetailsField;
            }
            set
            {
                this.proStoresDetailsField = value;
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
