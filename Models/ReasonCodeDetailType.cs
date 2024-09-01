    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReasonCodeDetailType
    {
        
        private string briefTextField;
        
        private string detailedTextField;
        
        private System.Xml.XmlElement[] anyField;
        
        private long codeIDField;
        
        private bool codeIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BriefText
        {
            get
            {
                return this.briefTextField;
            }
            set
            {
                this.briefTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailedText
        {
            get
            {
                return this.detailedTextField;
            }
            set
            {
                this.detailedTextField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long codeID
        {
            get
            {
                return this.codeIDField;
            }
            set
            {
                this.codeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeIDSpecified
        {
            get
            {
                return this.codeIDFieldSpecified;
            }
            set
            {
                this.codeIDFieldSpecified = value;
            }
        }
    }
