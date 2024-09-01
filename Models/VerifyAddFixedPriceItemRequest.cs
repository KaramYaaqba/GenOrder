    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyAddFixedPriceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyAddFixedPriceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyAddFixedPriceItemRequestType VerifyAddFixedPriceItemRequest1;
        
        public VerifyAddFixedPriceItemRequest()
        {
        }
        
        public VerifyAddFixedPriceItemRequest(CustomSecurityHeaderType RequesterCredentials,VerifyAddFixedPriceItemRequestType VerifyAddFixedPriceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyAddFixedPriceItemRequest1 = VerifyAddFixedPriceItemRequest1;
        }
    }
