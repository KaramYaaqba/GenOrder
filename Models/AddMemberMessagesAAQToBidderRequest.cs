    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMemberMessagesAAQToBidderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMemberMessagesAAQToBidderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddMemberMessagesAAQToBidderRequestType AddMemberMessagesAAQToBidderRequest1;
        
        public AddMemberMessagesAAQToBidderRequest()
        {
        }
        
        public AddMemberMessagesAAQToBidderRequest(CustomSecurityHeaderType RequesterCredentials,AddMemberMessagesAAQToBidderRequestType AddMemberMessagesAAQToBidderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddMemberMessagesAAQToBidderRequest1 = AddMemberMessagesAAQToBidderRequest1;
        }
    }
