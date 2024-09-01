    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreThemeArrayType
    {
        
        private StoreThemeType[] themeField;
        
        private StoreColorSchemeType[] genericColorSchemeArrayField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Theme" )]
        public StoreThemeType[] Theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ColorScheme", IsNullable=false)]
        public StoreColorSchemeType[] GenericColorSchemeArray
        {
            get
            {
                return this.genericColorSchemeArrayField;
            }
            set
            {
                this.genericColorSchemeArrayField = value;
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
