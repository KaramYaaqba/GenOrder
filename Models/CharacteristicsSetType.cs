    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CharacteristicsSetType
    {
        
        private string nameField;
        
        private int attributeSetIDField;
        
        private bool attributeSetIDFieldSpecified;
        
        private string attributeSetVersionField;
        
        private CharacteristicType[] characteristicsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int AttributeSetID
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
        public bool AttributeSetIDSpecified
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AttributeSetVersion
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Characteristics" )]
        public CharacteristicType[] Characteristics
        {
            get
            {
                return this.characteristicsField;
            }
            set
            {
                this.characteristicsField = value;
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
