    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BotBlockResponseType
    {
        
        private string botBlockTokenField;
        
        private string botBlockUrlField;
        
        private string botBlockAudioUrlField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BotBlockToken
        {
            get
            {
                return this.botBlockTokenField;
            }
            set
            {
                this.botBlockTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BotBlockUrl
        {
            get
            {
                return this.botBlockUrlField;
            }
            set
            {
                this.botBlockUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BotBlockAudioUrl
        {
            get
            {
                return this.botBlockAudioUrlField;
            }
            set
            {
                this.botBlockAudioUrlField = value;
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
