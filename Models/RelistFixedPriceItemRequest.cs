    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RelistFixedPriceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RelistFixedPriceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RelistFixedPriceItemRequestType RelistFixedPriceItemRequest1;
        
        public RelistFixedPriceItemRequest()
        {
        }
        
        public RelistFixedPriceItemRequest(CustomSecurityHeaderType RequesterCredentials,RelistFixedPriceItemRequestType RelistFixedPriceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RelistFixedPriceItemRequest1 = RelistFixedPriceItemRequest1;
        }
    }
