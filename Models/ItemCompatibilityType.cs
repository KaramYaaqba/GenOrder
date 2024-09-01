    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemCompatibilityType
    {
        
        private bool deleteField;
        
        private bool deleteFieldSpecified;
        
        private NameValueListType[] nameValueListField;
        
        private string compatibilityNotesField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteSpecified
        {
            get
            {
                return this.deleteFieldSpecified;
            }
            set
            {
                this.deleteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameValueList" )]
        public NameValueListType[] NameValueList
        {
            get
            {
                return this.nameValueListField;
            }
            set
            {
                this.nameValueListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CompatibilityNotes
        {
            get
            {
                return this.compatibilityNotesField;
            }
            set
            {
                this.compatibilityNotesField = value;
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
