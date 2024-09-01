    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EndItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EndItemsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public EndItemsRequestType EndItemsRequest1;
        
        public EndItemsRequest()
        {
        }
        
        public EndItemsRequest(CustomSecurityHeaderType RequesterCredentials,EndItemsRequestType EndItemsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.EndItemsRequest1 = EndItemsRequest1;
        }
    }
