    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddMemberMessagesAAQToBidderRequestContainerType
    {
        
        private string correlationIDField;
        
        private string itemIDField;
        
        private MemberMessageType memberMessageField;
        
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
        public MemberMessageType MemberMessage
        {
            get
            {
                return this.memberMessageField;
            }
            set
            {
                this.memberMessageField = value;
            }
        }
    }
