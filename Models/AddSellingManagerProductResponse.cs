    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerProductResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerProductResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerProductResponseType AddSellingManagerProductResponse1;
        
        public AddSellingManagerProductResponse()
        {
        }
        
        public AddSellingManagerProductResponse(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerProductResponseType AddSellingManagerProductResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerProductResponse1 = AddSellingManagerProductResponse1;
        }
    }
