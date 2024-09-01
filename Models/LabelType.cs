    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class LabelType
    {
        
        private string nameField;
        
        private System.Xml.XmlElement[] anyField;
        
        private bool visibleField;
        
        private bool visibleFieldSpecified;
        
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
        public bool visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibleSpecified
        {
            get
            {
                return this.visibleFieldSpecified;
            }
            set
            {
                this.visibleFieldSpecified = value;
            }
        }
    }
