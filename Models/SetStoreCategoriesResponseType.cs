    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetStoreCategoriesResponseType : AbstractResponseType
    {
        
        private long taskIDField;
        
        private bool taskIDFieldSpecified;
        
        private TaskStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private StoreCustomCategoryType[] customCategoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long TaskID
        {
            get
            {
                return this.taskIDField;
            }
            set
            {
                this.taskIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaskIDSpecified
        {
            get
            {
                return this.taskIDFieldSpecified;
            }
            set
            {
                this.taskIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TaskStatusCodeType Status
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
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomCategory", IsNullable=false)]
        public StoreCustomCategoryType[] CustomCategory
        {
            get
            {
                return this.customCategoryField;
            }
            set
            {
                this.customCategoryField = value;
            }
        }
    }
