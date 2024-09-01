    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DisputeResolutionType
    {
        
        private DisputeResolutionRecordTypeCodeType disputeResolutionRecordTypeField;
        
        private bool disputeResolutionRecordTypeFieldSpecified;
        
        private DisputeResolutionReasonCodeType disputeResolutionReasonField;
        
        private bool disputeResolutionReasonFieldSpecified;
        
        private System.DateTime resolutionTimeField;
        
        private bool resolutionTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeResolutionRecordTypeCodeType DisputeResolutionRecordType
        {
            get
            {
                return this.disputeResolutionRecordTypeField;
            }
            set
            {
                this.disputeResolutionRecordTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeResolutionRecordTypeSpecified
        {
            get
            {
                return this.disputeResolutionRecordTypeFieldSpecified;
            }
            set
            {
                this.disputeResolutionRecordTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeResolutionReasonCodeType DisputeResolutionReason
        {
            get
            {
                return this.disputeResolutionReasonField;
            }
            set
            {
                this.disputeResolutionReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeResolutionReasonSpecified
        {
            get
            {
                return this.disputeResolutionReasonFieldSpecified;
            }
            set
            {
                this.disputeResolutionReasonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ResolutionTime
        {
            get
            {
                return this.resolutionTimeField;
            }
            set
            {
                this.resolutionTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResolutionTimeSpecified
        {
            get
            {
                return this.resolutionTimeFieldSpecified;
            }
            set
            {
                this.resolutionTimeFieldSpecified = value;
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
