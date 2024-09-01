    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ThemeGroupType
    {
        
        private int groupIDField;
        
        private bool groupIDFieldSpecified;
        
        private string groupNameField;
        
        private int[] themeIDField;
        
        private int themeTotalField;
        
        private bool themeTotalFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroupIDSpecified
        {
            get
            {
                return this.groupIDFieldSpecified;
            }
            set
            {
                this.groupIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string GroupName
        {
            get
            {
                return this.groupNameField;
            }
            set
            {
                this.groupNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThemeID" )]
        public int[] ThemeID
        {
            get
            {
                return this.themeIDField;
            }
            set
            {
                this.themeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ThemeTotal
        {
            get
            {
                return this.themeTotalField;
            }
            set
            {
                this.themeTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThemeTotalSpecified
        {
            get
            {
                return this.themeTotalFieldSpecified;
            }
            set
            {
                this.themeTotalFieldSpecified = value;
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
