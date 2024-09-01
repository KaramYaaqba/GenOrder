    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ExtendedContactDetailsType
    {
        
        private ContactHoursDetailsType contactHoursDetailsField;
        
        private bool classifiedAdContactByEmailEnabledField;
        
        private bool classifiedAdContactByEmailEnabledFieldSpecified;
        
        private string payPerLeadPhoneNumberField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ContactHoursDetailsType ContactHoursDetails
        {
            get
            {
                return this.contactHoursDetailsField;
            }
            set
            {
                this.contactHoursDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ClassifiedAdContactByEmailEnabled
        {
            get
            {
                return this.classifiedAdContactByEmailEnabledField;
            }
            set
            {
                this.classifiedAdContactByEmailEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClassifiedAdContactByEmailEnabledSpecified
        {
            get
            {
                return this.classifiedAdContactByEmailEnabledFieldSpecified;
            }
            set
            {
                this.classifiedAdContactByEmailEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PayPerLeadPhoneNumber
        {
            get
            {
                return this.payPerLeadPhoneNumberField;
            }
            set
            {
                this.payPerLeadPhoneNumberField = value;
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
