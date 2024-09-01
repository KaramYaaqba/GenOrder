    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BidAssistantListType
    {
        
        private long bidGroupIDField;
        
        private bool bidGroupIDFieldSpecified;
        
        private bool includeNotesField;
        
        private bool includeNotesFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long BidGroupID
        {
            get
            {
                return this.bidGroupIDField;
            }
            set
            {
                this.bidGroupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidGroupIDSpecified
        {
            get
            {
                return this.bidGroupIDFieldSpecified;
            }
            set
            {
                this.bidGroupIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeNotes
        {
            get
            {
                return this.includeNotesField;
            }
            set
            {
                this.includeNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeNotesSpecified
        {
            get
            {
                return this.includeNotesFieldSpecified;
            }
            set
            {
                this.includeNotesFieldSpecified = value;
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
