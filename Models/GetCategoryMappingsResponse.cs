    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoryMappingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoryMappingsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoryMappingsResponseType GetCategoryMappingsResponse1;
        
        public GetCategoryMappingsResponse()
        {
        }
        
        public GetCategoryMappingsResponse(CustomSecurityHeaderType RequesterCredentials,GetCategoryMappingsResponseType GetCategoryMappingsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoryMappingsResponse1 = GetCategoryMappingsResponse1;
        }
    }
