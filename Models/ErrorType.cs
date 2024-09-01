    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ErrorType
    {
        
        private string shortMessageField;
        
        private string longMessageField;
        
        private string errorCodeField;
        
        private bool userDisplayHintField;
        
        private bool userDisplayHintFieldSpecified;
        
        private SeverityCodeType severityCodeField;
        
        private bool severityCodeFieldSpecified;
        
        private ErrorParameterType[] errorParametersField;
        
        private ErrorClassificationCodeType errorClassificationField;
        
        private bool errorClassificationFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShortMessage
        {
            get
            {
                return this.shortMessageField;
            }
            set
            {
                this.shortMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string LongMessage
        {
            get
            {
                return this.longMessageField;
            }
            set
            {
                this.longMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UserDisplayHint
        {
            get
            {
                return this.userDisplayHintField;
            }
            set
            {
                this.userDisplayHintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserDisplayHintSpecified
        {
            get
            {
                return this.userDisplayHintFieldSpecified;
            }
            set
            {
                this.userDisplayHintFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SeverityCodeType SeverityCode
        {
            get
            {
                return this.severityCodeField;
            }
            set
            {
                this.severityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeverityCodeSpecified
        {
            get
            {
                return this.severityCodeFieldSpecified;
            }
            set
            {
                this.severityCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ErrorParameters" )]
        public ErrorParameterType[] ErrorParameters
        {
            get
            {
                return this.errorParametersField;
            }
            set
            {
                this.errorParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ErrorClassificationCodeType ErrorClassification
        {
            get
            {
                return this.errorClassificationField;
            }
            set
            {
                this.errorClassificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorClassificationSpecified
        {
            get
            {
                return this.errorClassificationFieldSpecified;
            }
            set
            {
                this.errorClassificationFieldSpecified = value;
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
