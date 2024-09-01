    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetDescriptionTemplatesResponseType : AbstractResponseType
    {
        
        private DescriptionTemplateType[] descriptionTemplateField;
        
        private int layoutTotalField;
        
        private bool layoutTotalFieldSpecified;
        
        private int[] obsoleteLayoutIDField;
        
        private int[] obsoleteThemeIDField;
        
        private ThemeGroupType[] themeGroupField;
        
        private int themeTotalField;
        
        private bool themeTotalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DescriptionTemplate" )]
        public DescriptionTemplateType[] DescriptionTemplate
        {
            get
            {
                return this.descriptionTemplateField;
            }
            set
            {
                this.descriptionTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int LayoutTotal
        {
            get
            {
                return this.layoutTotalField;
            }
            set
            {
                this.layoutTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LayoutTotalSpecified
        {
            get
            {
                return this.layoutTotalFieldSpecified;
            }
            set
            {
                this.layoutTotalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObsoleteLayoutID" )]
        public int[] ObsoleteLayoutID
        {
            get
            {
                return this.obsoleteLayoutIDField;
            }
            set
            {
                this.obsoleteLayoutIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObsoleteThemeID" )]
        public int[] ObsoleteThemeID
        {
            get
            {
                return this.obsoleteThemeIDField;
            }
            set
            {
                this.obsoleteThemeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThemeGroup" )]
        public ThemeGroupType[] ThemeGroup
        {
            get
            {
                return this.themeGroupField;
            }
            set
            {
                this.themeGroupField = value;
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
    }
