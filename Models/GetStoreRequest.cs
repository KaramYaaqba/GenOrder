    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreRequestType GetStoreRequest1;
        
        public GetStoreRequest()
        {
        }
        
        public GetStoreRequest(CustomSecurityHeaderType RequesterCredentials,GetStoreRequestType GetStoreRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreRequest1 = GetStoreRequest1;
        }
    }
