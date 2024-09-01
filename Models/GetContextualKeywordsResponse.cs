    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContextualKeywordsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContextualKeywordsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetContextualKeywordsResponseType GetContextualKeywordsResponse1;
        
        public GetContextualKeywordsResponse()
        {
        }
        
        public GetContextualKeywordsResponse(CustomSecurityHeaderType RequesterCredentials,GetContextualKeywordsResponseType GetContextualKeywordsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetContextualKeywordsResponse1 = GetContextualKeywordsResponse1;
        }
    }
