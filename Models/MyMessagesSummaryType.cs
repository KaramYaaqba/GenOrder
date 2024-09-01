    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyMessagesSummaryType
    {
        
        private MyMessagesFolderSummaryType[] folderSummaryField;
        
        private int newAlertCountField;
        
        private bool newAlertCountFieldSpecified;
        
        private int newMessageCountField;
        
        private bool newMessageCountFieldSpecified;
        
        private int unresolvedAlertCountField;
        
        private bool unresolvedAlertCountFieldSpecified;
        
        private int flaggedMessageCountField;
        
        private bool flaggedMessageCountFieldSpecified;
        
        private int totalAlertCountField;
        
        private bool totalAlertCountFieldSpecified;
        
        private int totalMessageCountField;
        
        private bool totalMessageCountFieldSpecified;
        
        private int newHighPriorityCountField;
        
        private bool newHighPriorityCountFieldSpecified;
        
        private int totalHighPriorityCountField;
        
        private bool totalHighPriorityCountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FolderSummary" )]
        public MyMessagesFolderSummaryType[] FolderSummary
        {
            get
            {
                return this.folderSummaryField;
            }
            set
            {
                this.folderSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NewAlertCount
        {
            get
            {
                return this.newAlertCountField;
            }
            set
            {
                this.newAlertCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewAlertCountSpecified
        {
            get
            {
                return this.newAlertCountFieldSpecified;
            }
            set
            {
                this.newAlertCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NewMessageCount
        {
            get
            {
                return this.newMessageCountField;
            }
            set
            {
                this.newMessageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewMessageCountSpecified
        {
            get
            {
                return this.newMessageCountFieldSpecified;
            }
            set
            {
                this.newMessageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int UnresolvedAlertCount
        {
            get
            {
                return this.unresolvedAlertCountField;
            }
            set
            {
                this.unresolvedAlertCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnresolvedAlertCountSpecified
        {
            get
            {
                return this.unresolvedAlertCountFieldSpecified;
            }
            set
            {
                this.unresolvedAlertCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FlaggedMessageCount
        {
            get
            {
                return this.flaggedMessageCountField;
            }
            set
            {
                this.flaggedMessageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlaggedMessageCountSpecified
        {
            get
            {
                return this.flaggedMessageCountFieldSpecified;
            }
            set
            {
                this.flaggedMessageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalAlertCount
        {
            get
            {
                return this.totalAlertCountField;
            }
            set
            {
                this.totalAlertCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalAlertCountSpecified
        {
            get
            {
                return this.totalAlertCountFieldSpecified;
            }
            set
            {
                this.totalAlertCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalMessageCount
        {
            get
            {
                return this.totalMessageCountField;
            }
            set
            {
                this.totalMessageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalMessageCountSpecified
        {
            get
            {
                return this.totalMessageCountFieldSpecified;
            }
            set
            {
                this.totalMessageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NewHighPriorityCount
        {
            get
            {
                return this.newHighPriorityCountField;
            }
            set
            {
                this.newHighPriorityCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewHighPriorityCountSpecified
        {
            get
            {
                return this.newHighPriorityCountFieldSpecified;
            }
            set
            {
                this.newHighPriorityCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalHighPriorityCount
        {
            get
            {
                return this.totalHighPriorityCountField;
            }
            set
            {
                this.totalHighPriorityCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalHighPriorityCountSpecified
        {
            get
            {
                return this.totalHighPriorityCountFieldSpecified;
            }
            set
            {
                this.totalHighPriorityCountFieldSpecified = value;
            }
        }
    }
