    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddMemberMessagesAAQToBidderResponseContainerType
    {
        
        private string correlationIDField;
        
        private AckCodeType ackField;
        
        private bool ackFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CorrelationID
        {
            get
            {
                return this.correlationIDField;
            }
            set
            {
                this.correlationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AckCodeType Ack
        {
            get
            {
                return this.ackField;
            }
            set
            {
                this.ackField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AckSpecified
        {
            get
            {
                return this.ackFieldSpecified;
            }
            set
            {
                this.ackFieldSpecified = value;
            }
        }
    }
