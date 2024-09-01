    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategoriesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategoriesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategoriesRequestType GetCategoriesRequest1;
        
        public GetCategoriesRequest()
        {
        }
        
        public GetCategoriesRequest(CustomSecurityHeaderType RequesterCredentials,GetCategoriesRequestType GetCategoriesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategoriesRequest1 = GetCategoriesRequest1;
        }
    }
