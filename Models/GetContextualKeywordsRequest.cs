    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContextualKeywordsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContextualKeywordsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetContextualKeywordsRequestType GetContextualKeywordsRequest1;
        
        public GetContextualKeywordsRequest()
        {
        }
        
        public GetContextualKeywordsRequest(CustomSecurityHeaderType RequesterCredentials,GetContextualKeywordsRequestType GetContextualKeywordsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetContextualKeywordsRequest1 = GetContextualKeywordsRequest1;
        }
    }
