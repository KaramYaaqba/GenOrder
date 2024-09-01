    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompleteSaleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompleteSaleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public CompleteSaleResponseType CompleteSaleResponse1;
        
        public CompleteSaleResponse()
        {
        }
        
        public CompleteSaleResponse(CustomSecurityHeaderType RequesterCredentials,CompleteSaleResponseType CompleteSaleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.CompleteSaleResponse1 = CompleteSaleResponse1;
        }
    }
