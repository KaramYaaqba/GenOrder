    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChallengeTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChallengeTokenRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetChallengeTokenRequestType GetChallengeTokenRequest1;
        
        public GetChallengeTokenRequest()
        {
        }
        
        public GetChallengeTokenRequest(CustomSecurityHeaderType RequesterCredentials,GetChallengeTokenRequestType GetChallengeTokenRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetChallengeTokenRequest1 = GetChallengeTokenRequest1;
        }
    }
