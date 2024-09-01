    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddFixedPriceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddFixedPriceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddFixedPriceItemRequestType AddFixedPriceItemRequest1;
        
        public AddFixedPriceItemRequest()
        {
        }
        
        public AddFixedPriceItemRequest(CustomSecurityHeaderType RequesterCredentials,AddFixedPriceItemRequestType AddFixedPriceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddFixedPriceItemRequest1 = AddFixedPriceItemRequest1;
        }
    }
