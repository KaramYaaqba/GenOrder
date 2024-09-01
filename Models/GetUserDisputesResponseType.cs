    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetUserDisputesResponseType : AbstractResponseType
    {
        
        private string startingDisputeIDField;
        
        private string endingDisputeIDField;
        
        private DisputeType[] disputeArrayField;
        
        private int itemsPerPageField;
        
        private bool itemsPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private DisputeFilterCountType[] disputeFilterCountField;
        
        private PaginationResultType paginationResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StartingDisputeID
        {
            get
            {
                return this.startingDisputeIDField;
            }
            set
            {
                this.startingDisputeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EndingDisputeID
        {
            get
            {
                return this.endingDisputeIDField;
            }
            set
            {
                this.endingDisputeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Dispute", IsNullable=false)]
        public DisputeType[] DisputeArray
        {
            get
            {
                return this.disputeArrayField;
            }
            set
            {
                this.disputeArrayField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DisputeFilterCount" )]
        public DisputeFilterCountType[] DisputeFilterCount
        {
            get
            {
                return this.disputeFilterCountField;
            }
            set
            {
                this.disputeFilterCountField = value;
            }
        }
        
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
    }
