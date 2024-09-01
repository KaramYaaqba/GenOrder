    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PaginationResultType
    {
        
        private int totalNumberOfPagesField;
        
        private bool totalNumberOfPagesFieldSpecified;
        
        private int totalNumberOfEntriesField;
        
        private bool totalNumberOfEntriesFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalNumberOfPages
        {
            get
            {
                return this.totalNumberOfPagesField;
            }
            set
            {
                this.totalNumberOfPagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalNumberOfPagesSpecified
        {
            get
            {
                return this.totalNumberOfPagesFieldSpecified;
            }
            set
            {
                this.totalNumberOfPagesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalNumberOfEntries
        {
            get
            {
                return this.totalNumberOfEntriesField;
            }
            set
            {
                this.totalNumberOfEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalNumberOfEntriesSpecified
        {
            get
            {
                return this.totalNumberOfEntriesFieldSpecified;
            }
            set
            {
                this.totalNumberOfEntriesFieldSpecified = value;
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
