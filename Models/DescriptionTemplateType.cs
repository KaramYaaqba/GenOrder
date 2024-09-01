    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DescriptionTemplateType
    {
        
        private int groupIDField;
        
        private bool groupIDFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string imageURLField;
        
        private string nameField;
        
        private string templateXMLField;
        
        private DescriptionTemplateCodeType typeField;
        
        private bool typeFieldSpecified;
        
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
        public int ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ImageURL
        {
            get
            {
                return this.imageURLField;
            }
            set
            {
                this.imageURLField = value;
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
        public string TemplateXML
        {
            get
            {
                return this.templateXMLField;
            }
            set
            {
                this.templateXMLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DescriptionTemplateCodeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
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
