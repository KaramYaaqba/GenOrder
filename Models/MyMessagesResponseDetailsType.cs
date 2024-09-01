    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyMessagesResponseDetailsType
    {
        
        private bool responseEnabledField;
        
        private bool responseEnabledFieldSpecified;
        
        private string responseURLField;
        
        private System.DateTime userResponseDateField;
        
        private bool userResponseDateFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ResponseEnabled
        {
            get
            {
                return this.responseEnabledField;
            }
            set
            {
                this.responseEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResponseEnabledSpecified
        {
            get
            {
                return this.responseEnabledFieldSpecified;
            }
            set
            {
                this.responseEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ResponseURL
        {
            get
            {
                return this.responseURLField;
            }
            set
            {
                this.responseURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UserResponseDate
        {
            get
            {
                return this.userResponseDateField;
            }
            set
            {
                this.userResponseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserResponseDateSpecified
        {
            get
            {
                return this.userResponseDateFieldSpecified;
            }
            set
            {
                this.userResponseDateFieldSpecified = value;
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
