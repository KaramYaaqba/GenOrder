    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMemberMessagesAAQToBidderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMemberMessagesAAQToBidderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddMemberMessagesAAQToBidderResponseType AddMemberMessagesAAQToBidderResponse1;
        
        public AddMemberMessagesAAQToBidderResponse()
        {
        }
        
        public AddMemberMessagesAAQToBidderResponse(CustomSecurityHeaderType RequesterCredentials,AddMemberMessagesAAQToBidderResponseType AddMemberMessagesAAQToBidderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddMemberMessagesAAQToBidderResponse1 = AddMemberMessagesAAQToBidderResponse1;
        }
    }
