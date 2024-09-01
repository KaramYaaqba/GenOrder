    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseMyMessagesRequestType : AbstractRequestType
    {
        
        private string[] messageIDsField;
        
        private string[] alertIDsField;
        
        private bool readField;
        
        private bool readFieldSpecified;
        
        private bool flaggedField;
        
        private bool flaggedFieldSpecified;
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("MessageID", IsNullable=false)]
        public string[] MessageIDs
        {
            get
            {
                return this.messageIDsField;
            }
            set
            {
                this.messageIDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("AlertID", IsNullable=false)]
        public string[] AlertIDs
        {
            get
            {
                return this.alertIDsField;
            }
            set
            {
                this.alertIDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Read
        {
            get
            {
                return this.readField;
            }
            set
            {
                this.readField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReadSpecified
        {
            get
            {
                return this.readFieldSpecified;
            }
            set
            {
                this.readFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Flagged
        {
            get
            {
                return this.flaggedField;
            }
            set
            {
                this.flaggedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlaggedSpecified
        {
            get
            {
                return this.flaggedFieldSpecified;
            }
            set
            {
                this.flaggedFieldSpecified = value;
            }
        }
        
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
    }
