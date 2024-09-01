    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class EndOfAuctionEmailPreferencesType
    {
        
        private string templateTextField;
        
        private string logoURLField;
        
        private EndOfAuctionLogoTypeCodeType logoTypeField;
        
        private bool logoTypeFieldSpecified;
        
        private bool emailCustomizedField;
        
        private bool emailCustomizedFieldSpecified;
        
        private bool textCustomizedField;
        
        private bool textCustomizedFieldSpecified;
        
        private bool logoCustomizedField;
        
        private bool logoCustomizedFieldSpecified;
        
        private bool copyEmailField;
        
        private bool copyEmailFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TemplateText
        {
            get
            {
                return this.templateTextField;
            }
            set
            {
                this.templateTextField = value;
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
        public EndOfAuctionLogoTypeCodeType LogoType
        {
            get
            {
                return this.logoTypeField;
            }
            set
            {
                this.logoTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogoTypeSpecified
        {
            get
            {
                return this.logoTypeFieldSpecified;
            }
            set
            {
                this.logoTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EmailCustomized
        {
            get
            {
                return this.emailCustomizedField;
            }
            set
            {
                this.emailCustomizedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailCustomizedSpecified
        {
            get
            {
                return this.emailCustomizedFieldSpecified;
            }
            set
            {
                this.emailCustomizedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool TextCustomized
        {
            get
            {
                return this.textCustomizedField;
            }
            set
            {
                this.textCustomizedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TextCustomizedSpecified
        {
            get
            {
                return this.textCustomizedFieldSpecified;
            }
            set
            {
                this.textCustomizedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool LogoCustomized
        {
            get
            {
                return this.logoCustomizedField;
            }
            set
            {
                this.logoCustomizedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogoCustomizedSpecified
        {
            get
            {
                return this.logoCustomizedFieldSpecified;
            }
            set
            {
                this.logoCustomizedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CopyEmail
        {
            get
            {
                return this.copyEmailField;
            }
            set
            {
                this.copyEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CopyEmailSpecified
        {
            get
            {
                return this.copyEmailFieldSpecified;
            }
            set
            {
                this.copyEmailFieldSpecified = value;
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
