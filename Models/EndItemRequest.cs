    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EndItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EndItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public EndItemRequestType EndItemRequest1;
        
        public EndItemRequest()
        {
        }
        
        public EndItemRequest(CustomSecurityHeaderType RequesterCredentials,EndItemRequestType EndItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.EndItemRequest1 = EndItemRequest1;
        }
    }
