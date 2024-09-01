    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerProductRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerProductRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerProductRequestType DeleteSellingManagerProductRequest1;
        
        public DeleteSellingManagerProductRequest()
        {
        }
        
        public DeleteSellingManagerProductRequest(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerProductRequestType DeleteSellingManagerProductRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerProductRequest1 = DeleteSellingManagerProductRequest1;
        }
    }
