    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSuggestedCategoriesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSuggestedCategoriesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSuggestedCategoriesResponseType GetSuggestedCategoriesResponse1;
        
        public GetSuggestedCategoriesResponse()
        {
        }
        
        public GetSuggestedCategoriesResponse(CustomSecurityHeaderType RequesterCredentials,GetSuggestedCategoriesResponseType GetSuggestedCategoriesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSuggestedCategoriesResponse1 = GetSuggestedCategoriesResponse1;
        }
    }
