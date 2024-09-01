    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseCheckoutStatusRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseCheckoutStatusRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseCheckoutStatusRequestType ReviseCheckoutStatusRequest1;
        
        public ReviseCheckoutStatusRequest()
        {
        }
        
        public ReviseCheckoutStatusRequest(CustomSecurityHeaderType RequesterCredentials,ReviseCheckoutStatusRequestType ReviseCheckoutStatusRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseCheckoutStatusRequest1 = ReviseCheckoutStatusRequest1;
        }
    }
