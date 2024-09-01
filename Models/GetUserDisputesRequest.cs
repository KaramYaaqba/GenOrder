    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserDisputesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserDisputesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserDisputesRequestType GetUserDisputesRequest1;
        
        public GetUserDisputesRequest()
        {
        }
        
        public GetUserDisputesRequest(CustomSecurityHeaderType RequesterCredentials,GetUserDisputesRequestType GetUserDisputesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserDisputesRequest1 = GetUserDisputesRequest1;
        }
    }
