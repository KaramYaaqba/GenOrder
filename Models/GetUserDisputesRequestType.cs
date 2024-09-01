    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetUserDisputesRequestType : AbstractRequestType
    {
        
        private DisputeFilterTypeCodeType disputeFilterTypeField;
        
        private bool disputeFilterTypeFieldSpecified;
        
        private DisputeSortTypeCodeType disputeSortTypeField;
        
        private bool disputeSortTypeFieldSpecified;
        
        private System.DateTime modTimeFromField;
        
        private bool modTimeFromFieldSpecified;
        
        private System.DateTime modTimeToField;
        
        private bool modTimeToFieldSpecified;
        
        private PaginationType paginationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeFilterTypeCodeType DisputeFilterType
        {
            get
            {
                return this.disputeFilterTypeField;
            }
            set
            {
                this.disputeFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeFilterTypeSpecified
        {
            get
            {
                return this.disputeFilterTypeFieldSpecified;
            }
            set
            {
                this.disputeFilterTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeSortTypeCodeType DisputeSortType
        {
            get
            {
                return this.disputeSortTypeField;
            }
            set
            {
                this.disputeSortTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeSortTypeSpecified
        {
            get
            {
                return this.disputeSortTypeFieldSpecified;
            }
            set
            {
                this.disputeSortTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ModTimeFrom
        {
            get
            {
                return this.modTimeFromField;
            }
            set
            {
                this.modTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeFromSpecified
        {
            get
            {
                return this.modTimeFromFieldSpecified;
            }
            set
            {
                this.modTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ModTimeTo
        {
            get
            {
                return this.modTimeToField;
            }
            set
            {
                this.modTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeToSpecified
        {
            get
            {
                return this.modTimeToFieldSpecified;
            }
            set
            {
                this.modTimeToFieldSpecified = value;
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
