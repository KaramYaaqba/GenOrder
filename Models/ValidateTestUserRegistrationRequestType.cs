    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ValidateTestUserRegistrationRequestType : AbstractRequestType
    {
        
        private int feedbackScoreField;
        
        private bool feedbackScoreFieldSpecified;
        
        private System.DateTime registrationDateField;
        
        private bool registrationDateFieldSpecified;
        
        private bool subscribeSAField;
        
        private bool subscribeSAFieldSpecified;
        
        private bool subscribeSAProField;
        
        private bool subscribeSAProFieldSpecified;
        
        private bool subscribeSMField;
        
        private bool subscribeSMFieldSpecified;
        
        private bool subscribeSMProField;
        
        private bool subscribeSMProFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FeedbackScore
        {
            get
            {
                return this.feedbackScoreField;
            }
            set
            {
                this.feedbackScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackScoreSpecified
        {
            get
            {
                return this.feedbackScoreFieldSpecified;
            }
            set
            {
                this.feedbackScoreFieldSpecified = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SubscribeSA
        {
            get
            {
                return this.subscribeSAField;
            }
            set
            {
                this.subscribeSAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscribeSASpecified
        {
            get
            {
                return this.subscribeSAFieldSpecified;
            }
            set
            {
                this.subscribeSAFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SubscribeSAPro
        {
            get
            {
                return this.subscribeSAProField;
            }
            set
            {
                this.subscribeSAProField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscribeSAProSpecified
        {
            get
            {
                return this.subscribeSAProFieldSpecified;
            }
            set
            {
                this.subscribeSAProFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SubscribeSM
        {
            get
            {
                return this.subscribeSMField;
            }
            set
            {
                this.subscribeSMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscribeSMSpecified
        {
            get
            {
                return this.subscribeSMFieldSpecified;
            }
            set
            {
                this.subscribeSMFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SubscribeSMPro
        {
            get
            {
                return this.subscribeSMProField;
            }
            set
            {
                this.subscribeSMProField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscribeSMProSpecified
        {
            get
            {
                return this.subscribeSMProFieldSpecified;
            }
            set
            {
                this.subscribeSMProFieldSpecified = value;
            }
        }
    }
