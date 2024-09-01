    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccountRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccountRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAccountRequestType GetAccountRequest1;
        
        public GetAccountRequest()
        {
        }
        
        public GetAccountRequest(CustomSecurityHeaderType RequesterCredentials,GetAccountRequestType GetAccountRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAccountRequest1 = GetAccountRequest1;
        }
    }
