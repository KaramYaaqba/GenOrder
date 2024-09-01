    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EndFixedPriceItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EndFixedPriceItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public EndFixedPriceItemResponseType EndFixedPriceItemResponse1;
        
        public EndFixedPriceItemResponse()
        {
        }
        
        public EndFixedPriceItemResponse(CustomSecurityHeaderType RequesterCredentials,EndFixedPriceItemResponseType EndFixedPriceItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.EndFixedPriceItemResponse1 = EndFixedPriceItemResponse1;
        }
    }
