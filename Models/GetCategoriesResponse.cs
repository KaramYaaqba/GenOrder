    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoriesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoriesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoriesResponseType GetCategoriesResponse1;
        
        public GetCategoriesResponse()
        {
        }
        
        public GetCategoriesResponse(CustomSecurityHeaderType RequesterCredentials,GetCategoriesResponseType GetCategoriesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoriesResponse1 = GetCategoriesResponse1;
        }
    }
