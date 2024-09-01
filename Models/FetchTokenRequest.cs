    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FetchTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FetchTokenRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public FetchTokenRequestType FetchTokenRequest1;
        
        public FetchTokenRequest()
        {
        }
        
        public FetchTokenRequest(CustomSecurityHeaderType RequesterCredentials,FetchTokenRequestType FetchTokenRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.FetchTokenRequest1 = FetchTokenRequest1;
        }
    }
