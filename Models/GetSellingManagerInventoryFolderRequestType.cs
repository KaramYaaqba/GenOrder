    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerInventoryFolderRequestType : AbstractRequestType
    {
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        private int maxDepthField;
        
        private bool maxDepthFieldSpecified;
        
        private bool fullRecursionField;
        
        private bool fullRecursionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long FolderID
        {
            get
            {
                return this.folderIDField;
            }
            set
            {
                this.folderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolderIDSpecified
        {
            get
            {
                return this.folderIDFieldSpecified;
            }
            set
            {
                this.folderIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxDepth
        {
            get
            {
                return this.maxDepthField;
            }
            set
            {
                this.maxDepthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxDepthSpecified
        {
            get
            {
                return this.maxDepthFieldSpecified;
            }
            set
            {
                this.maxDepthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FullRecursion
        {
            get
            {
                return this.fullRecursionField;
            }
            set
            {
                this.fullRecursionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FullRecursionSpecified
        {
            get
            {
                return this.fullRecursionFieldSpecified;
            }
            set
            {
                this.fullRecursionFieldSpecified = value;
            }
        }
    }
