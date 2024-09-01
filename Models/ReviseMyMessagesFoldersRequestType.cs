    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseMyMessagesFoldersRequestType : AbstractRequestType
    {
        
        private MyMessagesFolderOperationCodeType operationField;
        
        private bool operationFieldSpecified;
        
        private long[] folderIDField;
        
        private string[] folderNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesFolderOperationCodeType Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationSpecified
        {
            get
            {
                return this.operationFieldSpecified;
            }
            set
            {
                this.operationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FolderID" )]
        public long[] FolderID
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
        [System.Xml.Serialization.XmlElementAttribute("FolderName" )]
        public string[] FolderName
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
    }
