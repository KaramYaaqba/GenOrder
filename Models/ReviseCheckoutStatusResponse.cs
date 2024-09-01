    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseCheckoutStatusResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseCheckoutStatusResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseCheckoutStatusResponseType ReviseCheckoutStatusResponse1;
        
        public ReviseCheckoutStatusResponse()
        {
        }
        
        public ReviseCheckoutStatusResponse(CustomSecurityHeaderType RequesterCredentials,ReviseCheckoutStatusResponseType ReviseCheckoutStatusResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseCheckoutStatusResponse1 = ReviseCheckoutStatusResponse1;
        }
    }
