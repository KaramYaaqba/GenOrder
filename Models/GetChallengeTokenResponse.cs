    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetChallengeTokenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetChallengeTokenResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetChallengeTokenResponseType GetChallengeTokenResponse1;
        
        public GetChallengeTokenResponse()
        {
        }
        
        public GetChallengeTokenResponse(CustomSecurityHeaderType RequesterCredentials,GetChallengeTokenResponseType GetChallengeTokenResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetChallengeTokenResponse1 = GetChallengeTokenResponse1;
        }
    }
