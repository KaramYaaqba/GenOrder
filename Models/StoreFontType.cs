    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreFontType
    {
        
        private StoreFontFaceCodeType nameFaceField;
        
        private bool nameFaceFieldSpecified;
        
        private StoreFontSizeCodeType nameSizeField;
        
        private bool nameSizeFieldSpecified;
        
        private string nameColorField;
        
        private StoreFontFaceCodeType titleFaceField;
        
        private bool titleFaceFieldSpecified;
        
        private StoreFontSizeCodeType titleSizeField;
        
        private bool titleSizeFieldSpecified;
        
        private string titleColorField;
        
        private StoreFontFaceCodeType descFaceField;
        
        private bool descFaceFieldSpecified;
        
        private StoreFontSizeCodeType descSizeField;
        
        private bool descSizeFieldSpecified;
        
        private string descColorField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontFaceCodeType NameFace
        {
            get
            {
                return this.nameFaceField;
            }
            set
            {
                this.nameFaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameFaceSpecified
        {
            get
            {
                return this.nameFaceFieldSpecified;
            }
            set
            {
                this.nameFaceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontSizeCodeType NameSize
        {
            get
            {
                return this.nameSizeField;
            }
            set
            {
                this.nameSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameSizeSpecified
        {
            get
            {
                return this.nameSizeFieldSpecified;
            }
            set
            {
                this.nameSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NameColor
        {
            get
            {
                return this.nameColorField;
            }
            set
            {
                this.nameColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontFaceCodeType TitleFace
        {
            get
            {
                return this.titleFaceField;
            }
            set
            {
                this.titleFaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TitleFaceSpecified
        {
            get
            {
                return this.titleFaceFieldSpecified;
            }
            set
            {
                this.titleFaceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontSizeCodeType TitleSize
        {
            get
            {
                return this.titleSizeField;
            }
            set
            {
                this.titleSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TitleSizeSpecified
        {
            get
            {
                return this.titleSizeFieldSpecified;
            }
            set
            {
                this.titleSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TitleColor
        {
            get
            {
                return this.titleColorField;
            }
            set
            {
                this.titleColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontFaceCodeType DescFace
        {
            get
            {
                return this.descFaceField;
            }
            set
            {
                this.descFaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescFaceSpecified
        {
            get
            {
                return this.descFaceFieldSpecified;
            }
            set
            {
                this.descFaceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreFontSizeCodeType DescSize
        {
            get
            {
                return this.descSizeField;
            }
            set
            {
                this.descSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescSizeSpecified
        {
            get
            {
                return this.descSizeFieldSpecified;
            }
            set
            {
                this.descSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DescColor
        {
            get
            {
                return this.descColorField;
            }
            set
            {
                this.descColorField = value;
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
