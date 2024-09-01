    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RevokeTokenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RevokeTokenResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RevokeTokenResponseType RevokeTokenResponse1;
        
        public RevokeTokenResponse()
        {
        }
        
        public RevokeTokenResponse(CustomSecurityHeaderType RequesterCredentials,RevokeTokenResponseType RevokeTokenResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RevokeTokenResponse1 = RevokeTokenResponse1;
        }
    }
