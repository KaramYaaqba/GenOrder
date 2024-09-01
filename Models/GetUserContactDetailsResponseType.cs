    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetUserContactDetailsResponseType : AbstractResponseType
    {
        
        private string userIDField;
        
        private AddressType contactAddressField;
        
        private System.DateTime registrationDateField;
        
        private bool registrationDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ContactAddress
        {
            get
            {
                return this.contactAddressField;
            }
            set
            {
                this.contactAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RegistrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistrationDateSpecified
        {
            get
            {
                return this.registrationDateFieldSpecified;
            }
            set
            {
                this.registrationDateFieldSpecified = value;
            }
        }
    }
