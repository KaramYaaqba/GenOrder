    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreCategoryUpdateStatusResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreCategoryUpdateStatusResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreCategoryUpdateStatusResponseType GetStoreCategoryUpdateStatusResponse1;
        
        public GetStoreCategoryUpdateStatusResponse()
        {
        }
        
        public GetStoreCategoryUpdateStatusResponse(CustomSecurityHeaderType RequesterCredentials,GetStoreCategoryUpdateStatusResponseType GetStoreCategoryUpdateStatusResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreCategoryUpdateStatusResponse1 = GetStoreCategoryUpdateStatusResponse1;
        }
    }
