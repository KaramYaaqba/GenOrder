    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStoreResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStoreResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStoreResponseType SetStoreResponse1;
        
        public SetStoreResponse()
        {
        }
        
        public SetStoreResponse(CustomSecurityHeaderType RequesterCredentials,SetStoreResponseType SetStoreResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStoreResponse1 = SetStoreResponse1;
        }
    }
