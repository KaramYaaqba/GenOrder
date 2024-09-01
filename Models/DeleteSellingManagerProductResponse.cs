    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerProductResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerProductResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerProductResponseType DeleteSellingManagerProductResponse1;
        
        public DeleteSellingManagerProductResponse()
        {
        }
        
        public DeleteSellingManagerProductResponse(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerProductResponseType DeleteSellingManagerProductResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerProductResponse1 = DeleteSellingManagerProductResponse1;
        }
    }
