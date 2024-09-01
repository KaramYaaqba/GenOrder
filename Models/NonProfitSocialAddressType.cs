    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NonProfitSocialAddressType
    {
        
        private SocialAddressTypeCodeType socialAddressTypeField;
        
        private bool socialAddressTypeFieldSpecified;
        
        private string socialAddressIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SocialAddressTypeCodeType SocialAddressType
        {
            get
            {
                return this.socialAddressTypeField;
            }
            set
            {
                this.socialAddressTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SocialAddressTypeSpecified
        {
            get
            {
                return this.socialAddressTypeFieldSpecified;
            }
            set
            {
                this.socialAddressTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SocialAddressId
        {
            get
            {
                return this.socialAddressIdField;
            }
            set
            {
                this.socialAddressIdField = value;
            }
        }
    }
