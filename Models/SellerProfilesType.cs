    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerProfilesType
    {
        
        private SellerShippingProfileType sellerShippingProfileField;
        
        private SellerReturnProfileType sellerReturnProfileField;
        
        private SellerPaymentProfileType sellerPaymentProfileField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerShippingProfileType SellerShippingProfile
        {
            get
            {
                return this.sellerShippingProfileField;
            }
            set
            {
                this.sellerShippingProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerReturnProfileType SellerReturnProfile
        {
            get
            {
                return this.sellerReturnProfileField;
            }
            set
            {
                this.sellerReturnProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerPaymentProfileType SellerPaymentProfile
        {
            get
            {
                return this.sellerPaymentProfileField;
            }
            set
            {
                this.sellerPaymentProfileField = value;
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
