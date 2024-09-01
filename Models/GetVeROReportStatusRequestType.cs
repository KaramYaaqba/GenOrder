    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetVeROReportStatusRequestType : AbstractRequestType
    {
        
        private long veROReportPacketIDField;
        
        private bool veROReportPacketIDFieldSpecified;
        
        private string itemIDField;
        
        private bool includeReportedItemDetailsField;
        
        private bool includeReportedItemDetailsFieldSpecified;
        
        private System.DateTime timeFromField;
        
        private bool timeFromFieldSpecified;
        
        private System.DateTime timeToField;
        
        private bool timeToFieldSpecified;
        
        private PaginationType paginationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long VeROReportPacketID
        {
            get
            {
                return this.veROReportPacketIDField;
            }
            set
            {
                this.veROReportPacketIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeROReportPacketIDSpecified
        {
            get
            {
                return this.veROReportPacketIDFieldSpecified;
            }
            set
            {
                this.veROReportPacketIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeReportedItemDetails
        {
            get
            {
                return this.includeReportedItemDetailsField;
            }
            set
            {
                this.includeReportedItemDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeReportedItemDetailsSpecified
        {
            get
            {
                return this.includeReportedItemDetailsFieldSpecified;
            }
            set
            {
                this.includeReportedItemDetailsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeFrom
        {
            get
            {
                return this.timeFromField;
            }
            set
            {
                this.timeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeFromSpecified
        {
            get
            {
                return this.timeFromFieldSpecified;
            }
            set
            {
                this.timeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeTo
        {
            get
            {
                return this.timeToField;
            }
            set
            {
                this.timeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeToSpecified
        {
            get
            {
                return this.timeToFieldSpecified;
            }
            set
            {
                this.timeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
    }
