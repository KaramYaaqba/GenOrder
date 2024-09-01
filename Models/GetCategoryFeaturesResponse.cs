    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoryFeaturesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoryFeaturesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoryFeaturesResponseType GetCategoryFeaturesResponse1;
        
        public GetCategoryFeaturesResponse()
        {
        }
        
        public GetCategoryFeaturesResponse(CustomSecurityHeaderType RequesterCredentials,GetCategoryFeaturesResponseType GetCategoryFeaturesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoryFeaturesResponse1 = GetCategoryFeaturesResponse1;
        }
    }
