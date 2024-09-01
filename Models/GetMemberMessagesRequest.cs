    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMemberMessagesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMemberMessagesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMemberMessagesRequestType GetMemberMessagesRequest1;
        
        public GetMemberMessagesRequest()
        {
        }
        
        public GetMemberMessagesRequest(CustomSecurityHeaderType RequesterCredentials,GetMemberMessagesRequestType GetMemberMessagesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMemberMessagesRequest1 = GetMemberMessagesRequest1;
        }
    }
