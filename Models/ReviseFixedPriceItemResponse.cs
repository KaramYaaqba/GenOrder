    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseFixedPriceItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseFixedPriceItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseFixedPriceItemResponseType ReviseFixedPriceItemResponse1;
        
        public ReviseFixedPriceItemResponse()
        {
        }
        
        public ReviseFixedPriceItemResponse(CustomSecurityHeaderType RequesterCredentials,ReviseFixedPriceItemResponseType ReviseFixedPriceItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseFixedPriceItemResponse1 = ReviseFixedPriceItemResponse1;
        }
    }
