    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ValType
    {
        
        private string valueLiteralField;
        
        private string[] suggestedValueLiteralField;
        
        private int valueIDField;
        
        private bool valueIDFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ValueLiteral
        {
            get
            {
                return this.valueLiteralField;
            }
            set
            {
                this.valueLiteralField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SuggestedValueLiteral" )]
        public string[] SuggestedValueLiteral
        {
            get
            {
                return this.suggestedValueLiteralField;
            }
            set
            {
                this.suggestedValueLiteralField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ValueID
        {
            get
            {
                return this.valueIDField;
            }
            set
            {
                this.valueIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueIDSpecified
        {
            get
            {
                return this.valueIDFieldSpecified;
            }
            set
            {
                this.valueIDFieldSpecified = value;
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
