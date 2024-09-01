    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreCategoryUpdateStatusRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreCategoryUpdateStatusRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreCategoryUpdateStatusRequestType GetStoreCategoryUpdateStatusRequest1;
        
        public GetStoreCategoryUpdateStatusRequest()
        {
        }
        
        public GetStoreCategoryUpdateStatusRequest(CustomSecurityHeaderType RequesterCredentials,GetStoreCategoryUpdateStatusRequestType GetStoreCategoryUpdateStatusRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreCategoryUpdateStatusRequest1 = GetStoreCategoryUpdateStatusRequest1;
        }
    }
