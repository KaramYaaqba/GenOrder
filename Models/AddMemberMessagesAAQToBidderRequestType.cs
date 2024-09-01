    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddMemberMessagesAAQToBidderRequestType : AbstractRequestType
    {
        
        private AddMemberMessagesAAQToBidderRequestContainerType[] addMemberMessagesAAQToBidderRequestContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddMemberMessagesAAQToBidderRequestContainer" )]
        public AddMemberMessagesAAQToBidderRequestContainerType[] AddMemberMessagesAAQToBidderRequestContainer
        {
            get
            {
                return this.addMemberMessagesAAQToBidderRequestContainerField;
            }
            set
            {
                this.addMemberMessagesAAQToBidderRequestContainerField = value;
            }
        }
    }
