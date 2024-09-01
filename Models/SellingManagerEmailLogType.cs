    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerEmailLogType
    {
        
        private SellingManagerEmailTypeCodeType emailTypeField;
        
        private bool emailTypeFieldSpecified;
        
        private string customEmailNameField;
        
        private SellingManagerEmailSentStatusCodeType emailStateField;
        
        private bool emailStateFieldSpecified;
        
        private System.DateTime eventTimeField;
        
        private bool eventTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerEmailTypeCodeType EmailType
        {
            get
            {
                return this.emailTypeField;
            }
            set
            {
                this.emailTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailTypeSpecified
        {
            get
            {
                return this.emailTypeFieldSpecified;
            }
            set
            {
                this.emailTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CustomEmailName
        {
            get
            {
                return this.customEmailNameField;
            }
            set
            {
                this.customEmailNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerEmailSentStatusCodeType EmailState
        {
            get
            {
                return this.emailStateField;
            }
            set
            {
                this.emailStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailStateSpecified
        {
            get
            {
                return this.emailStateFieldSpecified;
            }
            set
            {
                this.emailStateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EventTime
        {
            get
            {
                return this.eventTimeField;
            }
            set
            {
                this.eventTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventTimeSpecified
        {
            get
            {
                return this.eventTimeFieldSpecified;
            }
            set
            {
                this.eventTimeFieldSpecified = value;
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
