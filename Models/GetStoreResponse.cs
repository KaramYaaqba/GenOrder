    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreResponseType GetStoreResponse1;
        
        public GetStoreResponse()
        {
        }
        
        public GetStoreResponse(CustomSecurityHeaderType RequesterCredentials,GetStoreResponseType GetStoreResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreResponse1 = GetStoreResponse1;
        }
    }
