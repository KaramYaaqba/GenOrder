    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreCustomPageType
    {
        
        private string nameField;
        
        private long pageIDField;
        
        private bool pageIDFieldSpecified;
        
        private string uRLPathField;
        
        private string uRLField;
        
        private StoreCustomPageStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private string contentField;
        
        private bool leftNavField;
        
        private bool leftNavFieldSpecified;
        
        private bool previewEnabledField;
        
        private bool previewEnabledFieldSpecified;
        
        private int orderField;
        
        private bool orderFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public long PageID
        {
            get
            {
                return this.pageIDField;
            }
            set
            {
                this.pageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageIDSpecified
        {
            get
            {
                return this.pageIDFieldSpecified;
            }
            set
            {
                this.pageIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string URLPath
        {
            get
            {
                return this.uRLPathField;
            }
            set
            {
                this.uRLPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomPageStatusCodeType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool LeftNav
        {
            get
            {
                return this.leftNavField;
            }
            set
            {
                this.leftNavField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeftNavSpecified
        {
            get
            {
                return this.leftNavFieldSpecified;
            }
            set
            {
                this.leftNavFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PreviewEnabled
        {
            get
            {
                return this.previewEnabledField;
            }
            set
            {
                this.previewEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreviewEnabledSpecified
        {
            get
            {
                return this.previewEnabledFieldSpecified;
            }
            set
            {
                this.previewEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderSpecified
        {
            get
            {
                return this.orderFieldSpecified;
            }
            set
            {
                this.orderFieldSpecified = value;
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
