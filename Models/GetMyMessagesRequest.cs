    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyMessagesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyMessagesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyMessagesRequestType GetMyMessagesRequest1;
        
        public GetMyMessagesRequest()
        {
        }
        
        public GetMyMessagesRequest(CustomSecurityHeaderType RequesterCredentials,GetMyMessagesRequestType GetMyMessagesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyMessagesRequest1 = GetMyMessagesRequest1;
        }
    }
