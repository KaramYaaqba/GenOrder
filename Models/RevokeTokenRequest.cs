    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevokeTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevokeTokenRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RevokeTokenRequestType RevokeTokenRequest1;
        
        public RevokeTokenRequest()
        {
        }
        
        public RevokeTokenRequest(CustomSecurityHeaderType RequesterCredentials,RevokeTokenRequestType RevokeTokenRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RevokeTokenRequest1 = RevokeTokenRequest1;
        }
    }
