    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AttributeSetType
    {
        
        private AttributeType[] attributeField;
        
        private System.Xml.XmlElement[] anyField;
        
        private int attributeSetIDField;
        
        private bool attributeSetIDFieldSpecified;
        
        private string attributeSetVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute" )]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
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
        public int attributeSetID
        {
            get
            {
                return this.attributeSetIDField;
            }
            set
            {
                this.attributeSetIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attributeSetIDSpecified
        {
            get
            {
                return this.attributeSetIDFieldSpecified;
            }
            set
            {
                this.attributeSetIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attributeSetVersion
        {
            get
            {
                return this.attributeSetVersionField;
            }
            set
            {
                this.attributeSetVersionField = value;
            }
        }
    }
