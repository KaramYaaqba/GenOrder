    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSellingManagerInventoryFolderRequestType : AbstractRequestType
    {
        
        private string folderNameField;
        
        private long parentFolderIDField;
        
        private bool parentFolderIDFieldSpecified;
        
        private string commentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FolderName
        {
            get
            {
                return this.folderNameField;
            }
            set
            {
                this.folderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ParentFolderID
        {
            get
            {
                return this.parentFolderIDField;
            }
            set
            {
                this.parentFolderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParentFolderIDSpecified
        {
            get
            {
                return this.parentFolderIDFieldSpecified;
            }
            set
            {
                this.parentFolderIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }
