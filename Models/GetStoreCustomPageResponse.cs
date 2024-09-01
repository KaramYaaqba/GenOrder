    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreCustomPageResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreCustomPageResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreCustomPageResponseType GetStoreCustomPageResponse1;
        
        public GetStoreCustomPageResponse()
        {
        }
        
        public GetStoreCustomPageResponse(CustomSecurityHeaderType RequesterCredentials,GetStoreCustomPageResponseType GetStoreCustomPageResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreCustomPageResponse1 = GetStoreCustomPageResponse1;
        }
    }
