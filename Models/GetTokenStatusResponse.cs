    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTokenStatusResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTokenStatusResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetTokenStatusResponseType GetTokenStatusResponse1;
        
        public GetTokenStatusResponse()
        {
        }
        
        public GetTokenStatusResponse(CustomSecurityHeaderType RequesterCredentials,GetTokenStatusResponseType GetTokenStatusResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetTokenStatusResponse1 = GetTokenStatusResponse1;
        }
    }
