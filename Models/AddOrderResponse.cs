    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddOrderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddOrderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddOrderResponseType AddOrderResponse1;
        
        public AddOrderResponse()
        {
        }
        
        public AddOrderResponse(CustomSecurityHeaderType RequesterCredentials,AddOrderResponseType AddOrderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddOrderResponse1 = AddOrderResponse1;
        }
    }
