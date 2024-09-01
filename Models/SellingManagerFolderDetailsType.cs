    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerFolderDetailsType
    {
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        private long parentFolderIDField;
        
        private bool parentFolderIDFieldSpecified;
        
        private long folderLevelField;
        
        private bool folderLevelFieldSpecified;
        
        private string folderNameField;
        
        private string folderCommentField;
        
        private SellingManagerFolderDetailsType[] childFolderField;
        
        private System.DateTime creationTimeField;
        
        private bool creationTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public long FolderLevel
        {
            get
            {
                return this.folderLevelField;
            }
            set
            {
                this.folderLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolderLevelSpecified
        {
            get
            {
                return this.folderLevelFieldSpecified;
            }
            set
            {
                this.folderLevelFieldSpecified = value;
            }
        }
        
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
        public string FolderComment
        {
            get
            {
                return this.folderCommentField;
            }
            set
            {
                this.folderCommentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildFolder" )]
        public SellingManagerFolderDetailsType[] ChildFolder
        {
            get
            {
                return this.childFolderField;
            }
            set
            {
                this.childFolderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreationTime
        {
            get
            {
                return this.creationTimeField;
            }
            set
            {
                this.creationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationTimeSpecified
        {
            get
            {
                return this.creationTimeFieldSpecified;
            }
            set
            {
                this.creationTimeFieldSpecified = value;
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
