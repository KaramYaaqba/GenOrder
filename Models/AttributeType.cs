    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AttributeType
    {
        
        private ValType[] valueField;
        
        private System.Xml.XmlElement[] anyField;
        
        private int attributeIDField;
        
        private bool attributeIDFieldSpecified;
        
        private string attributeLabelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value" )]
        public ValType[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
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
        public int attributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attributeIDSpecified
        {
            get
            {
                return this.attributeIDFieldSpecified;
            }
            set
            {
                this.attributeIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeLabel
        {
            get
            {
                return this.attributeLabelField;
            }
            set
            {
                this.attributeLabelField = value;
            }
        }
    }
