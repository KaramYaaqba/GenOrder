    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ListingDurationDefinitionType
    {
        
        private string[] durationField;
        
        private System.Xml.XmlElement[] anyField;
        
        private int durationSetIDField;
        
        private bool durationSetIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Duration", DataType="token" )]
        public string[] Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
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
        public int durationSetID
        {
            get
            {
                return this.durationSetIDField;
            }
            set
            {
                this.durationSetIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationSetIDSpecified
        {
            get
            {
                return this.durationSetIDFieldSpecified;
            }
            set
            {
                this.durationSetIDFieldSpecified = value;
            }
        }
    }
