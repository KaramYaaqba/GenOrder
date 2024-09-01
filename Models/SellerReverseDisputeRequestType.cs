    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerReverseDisputeRequestType : AbstractRequestType
    {
        
        private string disputeIDField;
        
        private DisputeResolutionReasonCodeType disputeResolutionReasonField;
        
        private bool disputeResolutionReasonFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DisputeID
        {
            get
            {
                return this.disputeIDField;
            }
            set
            {
                this.disputeIDField = value;
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
    }
