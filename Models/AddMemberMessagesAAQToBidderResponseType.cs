    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddMemberMessagesAAQToBidderResponseType : AbstractResponseType
    {
        
        private AddMemberMessagesAAQToBidderResponseContainerType[] addMemberMessagesAAQToBidderResponseContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddMemberMessagesAAQToBidderResponseContainer" )]
        public AddMemberMessagesAAQToBidderResponseContainerType[] AddMemberMessagesAAQToBidderResponseContainer
        {
            get
            {
                return this.addMemberMessagesAAQToBidderResponseContainerField;
            }
            set
            {
                this.addMemberMessagesAAQToBidderResponseContainerField = value;
            }
        }
    }
