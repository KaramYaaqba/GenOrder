    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSuggestedCategoriesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSuggestedCategoriesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSuggestedCategoriesRequestType GetSuggestedCategoriesRequest1;
        
        public GetSuggestedCategoriesRequest()
        {
        }
        
        public GetSuggestedCategoriesRequest(CustomSecurityHeaderType RequesterCredentials,GetSuggestedCategoriesRequestType GetSuggestedCategoriesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSuggestedCategoriesRequest1 = GetSuggestedCategoriesRequest1;
        }
    }
