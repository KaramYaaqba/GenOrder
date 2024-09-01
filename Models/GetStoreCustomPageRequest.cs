    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreCustomPageRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreCustomPageRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreCustomPageRequestType GetStoreCustomPageRequest1;
        
        public GetStoreCustomPageRequest()
        {
        }
        
        public GetStoreCustomPageRequest(CustomSecurityHeaderType RequesterCredentials,GetStoreCustomPageRequestType GetStoreCustomPageRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreCustomPageRequest1 = GetStoreCustomPageRequest1;
        }
    }
