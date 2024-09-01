    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerProductResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerProductResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerProductResponseType ReviseSellingManagerProductResponse1;
        
        public ReviseSellingManagerProductResponse()
        {
        }
        
        public ReviseSellingManagerProductResponse(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerProductResponseType ReviseSellingManagerProductResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerProductResponse1 = ReviseSellingManagerProductResponse1;
        }
    }
