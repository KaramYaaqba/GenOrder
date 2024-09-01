    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DisputeFilterCountType
    {
        
        private DisputeFilterTypeCodeType disputeFilterTypeField;
        
        private bool disputeFilterTypeFieldSpecified;
        
        private int totalAvailableField;
        
        private bool totalAvailableFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public int TotalAvailable
        {
            get
            {
                return this.totalAvailableField;
            }
            set
            {
                this.totalAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalAvailableSpecified
        {
            get
            {
                return this.totalAvailableFieldSpecified;
            }
            set
            {
                this.totalAvailableFieldSpecified = value;
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
