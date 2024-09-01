    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreColorSchemeType
    {
        
        private int colorSchemeIDField;
        
        private bool colorSchemeIDFieldSpecified;
        
        private string nameField;
        
        private StoreColorType colorField;
        
        private StoreFontType fontField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ColorSchemeID
        {
            get
            {
                return this.colorSchemeIDField;
            }
            set
            {
                this.colorSchemeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColorSchemeIDSpecified
        {
            get
            {
                return this.colorSchemeIDFieldSpecified;
            }
            set
            {
                this.colorSchemeIDFieldSpecified = value;
            }
        }
        
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
        public StoreColorType Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontType Font
        {
            get
            {
                return this.fontField;
            }
            set
            {
                this.fontField = value;
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
