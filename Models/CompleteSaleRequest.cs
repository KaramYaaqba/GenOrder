    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompleteSaleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompleteSaleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public CompleteSaleRequestType CompleteSaleRequest1;
        
        public CompleteSaleRequest()
        {
        }
        
        public CompleteSaleRequest(CustomSecurityHeaderType RequesterCredentials,CompleteSaleRequestType CompleteSaleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.CompleteSaleRequest1 = CompleteSaleRequest1;
        }
    }
