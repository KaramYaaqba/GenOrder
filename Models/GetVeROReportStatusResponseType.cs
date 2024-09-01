    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetVeROReportStatusResponseType : AbstractResponseType
    {
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreItemsField;
        
        private bool hasMoreItemsFieldSpecified;
        
        private int itemsPerPageField;
        
        private bool itemsPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private long veROReportPacketIDField;
        
        private bool veROReportPacketIDFieldSpecified;
        
        private VeROReportPacketStatusCodeType veROReportPacketStatusField;
        
        private bool veROReportPacketStatusFieldSpecified;
        
        private VeROReportedItemType[] reportedItemDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationResultType PaginationResult
        {
            get
            {
                return this.paginationResultField;
            }
            set
            {
                this.paginationResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasMoreItems
        {
            get
            {
                return this.hasMoreItemsField;
            }
            set
            {
                this.hasMoreItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreItemsSpecified
        {
            get
            {
                return this.hasMoreItemsFieldSpecified;
            }
            set
            {
                this.hasMoreItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ItemsPerPage
        {
            get
            {
                return this.itemsPerPageField;
            }
            set
            {
                this.itemsPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemsPerPageSpecified
        {
            get
            {
                return this.itemsPerPageFieldSpecified;
            }
            set
            {
                this.itemsPerPageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageNumberSpecified
        {
            get
            {
                return this.pageNumberFieldSpecified;
            }
            set
            {
                this.pageNumberFieldSpecified = value;
            }
        }
        
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
        public VeROReportPacketStatusCodeType VeROReportPacketStatus
        {
            get
            {
                return this.veROReportPacketStatusField;
            }
            set
            {
                this.veROReportPacketStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeROReportPacketStatusSpecified
        {
            get
            {
                return this.veROReportPacketStatusFieldSpecified;
            }
            set
            {
                this.veROReportPacketStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ReportedItem", IsNullable=false)]
        public VeROReportedItemType[] ReportedItemDetails
        {
            get
            {
                return this.reportedItemDetailsField;
            }
            set
            {
                this.reportedItemDetailsField = value;
            }
        }
    }
