    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerProductRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerProductRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerProductRequestType ReviseSellingManagerProductRequest1;
        
        public ReviseSellingManagerProductRequest()
        {
        }
        
        public ReviseSellingManagerProductRequest(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerProductRequestType ReviseSellingManagerProductRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerProductRequest1 = ReviseSellingManagerProductRequest1;
        }
    }
