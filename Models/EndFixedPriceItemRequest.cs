    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EndFixedPriceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EndFixedPriceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public EndFixedPriceItemRequestType EndFixedPriceItemRequest1;
        
        public EndFixedPriceItemRequest()
        {
        }
        
        public EndFixedPriceItemRequest(CustomSecurityHeaderType RequesterCredentials,EndFixedPriceItemRequestType EndFixedPriceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.EndFixedPriceItemRequest1 = EndFixedPriceItemRequest1;
        }
    }
