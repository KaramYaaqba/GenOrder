    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoryFeaturesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoryFeaturesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoryFeaturesRequestType GetCategoryFeaturesRequest1;
        
        public GetCategoryFeaturesRequest()
        {
        }
        
        public GetCategoryFeaturesRequest(CustomSecurityHeaderType RequesterCredentials,GetCategoryFeaturesRequestType GetCategoryFeaturesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoryFeaturesRequest1 = GetCategoryFeaturesRequest1;
        }
    }
