    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoryMappingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoryMappingsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoryMappingsRequestType GetCategoryMappingsRequest1;
        
        public GetCategoryMappingsRequest()
        {
        }
        
        public GetCategoryMappingsRequest(CustomSecurityHeaderType RequesterCredentials,GetCategoryMappingsRequestType GetCategoryMappingsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoryMappingsRequest1 = GetCategoryMappingsRequest1;
        }
    }
