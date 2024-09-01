    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TaxIdentifierAttributeType
    {
        
        private TaxIdentifierAttributeCodeType nameField;
        
        private bool nameFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxIdentifierAttributeCodeType name
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nameSpecified
        {
            get
            {
                return this.nameFieldSpecified;
            }
            set
            {
                this.nameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    }
