    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ASQPreferencesType
    {
        
        private bool resetDefaultSubjectsField;
        
        private bool resetDefaultSubjectsFieldSpecified;
        
        private string[] subjectField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ResetDefaultSubjects
        {
            get
            {
                return this.resetDefaultSubjectsField;
            }
            set
            {
                this.resetDefaultSubjectsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResetDefaultSubjectsSpecified
        {
            get
            {
                return this.resetDefaultSubjectsFieldSpecified;
            }
            set
            {
                this.resetDefaultSubjectsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject" )]
        public string[] Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
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
