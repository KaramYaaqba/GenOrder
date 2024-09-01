    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFixedPriceItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFixedPriceItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddFixedPriceItemResponseType AddFixedPriceItemResponse1;
        
        public AddFixedPriceItemResponse()
        {
        }
        
        public AddFixedPriceItemResponse(CustomSecurityHeaderType RequesterCredentials,AddFixedPriceItemResponseType AddFixedPriceItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddFixedPriceItemResponse1 = AddFixedPriceItemResponse1;
        }
    }
