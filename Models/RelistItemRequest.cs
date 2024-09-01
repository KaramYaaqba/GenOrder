    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RelistItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RelistItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RelistItemRequestType RelistItemRequest1;
        
        public RelistItemRequest()
        {
        }
        
        public RelistItemRequest(CustomSecurityHeaderType RequesterCredentials,RelistItemRequestType RelistItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RelistItemRequest1 = RelistItemRequest1;
        }
    }
