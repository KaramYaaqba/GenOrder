    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MoveSellingManagerInventoryFolderRequestType : AbstractRequestType
    {
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        private long newParentFolderIDField;
        
        private bool newParentFolderIDFieldSpecified;
        
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
        public long NewParentFolderID
        {
            get
            {
                return this.newParentFolderIDField;
            }
            set
            {
                this.newParentFolderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewParentFolderIDSpecified
        {
            get
            {
                return this.newParentFolderIDFieldSpecified;
            }
            set
            {
                this.newParentFolderIDFieldSpecified = value;
            }
        }
    }
