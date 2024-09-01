    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseSellingManagerInventoryFolderRequestType : AbstractRequestType
    {
        
        private SellingManagerFolderDetailsType folderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerFolderDetailsType Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }
    }
