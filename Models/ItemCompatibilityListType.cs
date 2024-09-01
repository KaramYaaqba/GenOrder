    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemCompatibilityListType
    {
        
        private ItemCompatibilityType[] compatibilityField;
        
        private bool replaceAllField;
        
        private bool replaceAllFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Compatibility" )]
        public ItemCompatibilityType[] Compatibility
        {
            get
            {
                return this.compatibilityField;
            }
            set
            {
                this.compatibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReplaceAll
        {
            get
            {
                return this.replaceAllField;
            }
            set
            {
                this.replaceAllField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReplaceAllSpecified
        {
            get
            {
                return this.replaceAllFieldSpecified;
            }
            set
            {
                this.replaceAllFieldSpecified = value;
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
