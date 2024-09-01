    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CategoryGroupType
    {
        
        private string nameField;
        
        private bool isDefaultField;
        
        private bool isDefaultFieldSpecified;
        
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
        public bool IsDefault
        {
            get
            {
                return this.isDefaultField;
            }
            set
            {
                this.isDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDefaultSpecified
        {
            get
            {
                return this.isDefaultFieldSpecified;
            }
            set
            {
                this.isDefaultFieldSpecified = value;
            }
        }
    }
