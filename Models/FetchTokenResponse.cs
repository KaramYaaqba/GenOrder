    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FetchTokenResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FetchTokenResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public FetchTokenResponseType FetchTokenResponse1;
        
        public FetchTokenResponse()
        {
        }
        
        public FetchTokenResponse(CustomSecurityHeaderType RequesterCredentials,FetchTokenResponseType FetchTokenResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.FetchTokenResponse1 = FetchTokenResponse1;
        }
    }
