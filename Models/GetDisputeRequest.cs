    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDisputeRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDisputeRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetDisputeRequestType GetDisputeRequest1;
        
        public GetDisputeRequest()
        {
        }
        
        public GetDisputeRequest(CustomSecurityHeaderType RequesterCredentials,GetDisputeRequestType GetDisputeRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetDisputeRequest1 = GetDisputeRequest1;
        }
    }
