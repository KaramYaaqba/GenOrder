    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BidGroupType
    {
        
        private BidGroupItemType[] bidGroupItemField;
        
        private long bidGroupIDField;
        
        private bool bidGroupIDFieldSpecified;
        
        private string bidGroupNameField;
        
        private BidGroupStatusCodeType bidGroupStatusField;
        
        private bool bidGroupStatusFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BidGroupItem" )]
        public BidGroupItemType[] BidGroupItem
        {
            get
            {
                return this.bidGroupItemField;
            }
            set
            {
                this.bidGroupItemField = value;
            }
        }
        
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
        public string BidGroupName
        {
            get
            {
                return this.bidGroupNameField;
            }
            set
            {
                this.bidGroupNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BidGroupStatusCodeType BidGroupStatus
        {
            get
            {
                return this.bidGroupStatusField;
            }
            set
            {
                this.bidGroupStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidGroupStatusSpecified
        {
            get
            {
                return this.bidGroupStatusFieldSpecified;
            }
            set
            {
                this.bidGroupStatusFieldSpecified = value;
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
