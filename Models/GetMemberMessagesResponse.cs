    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMemberMessagesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMemberMessagesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMemberMessagesResponseType GetMemberMessagesResponse1;
        
        public GetMemberMessagesResponse()
        {
        }
        
        public GetMemberMessagesResponse(CustomSecurityHeaderType RequesterCredentials,GetMemberMessagesResponseType GetMemberMessagesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMemberMessagesResponse1 = GetMemberMessagesResponse1;
        }
    }
