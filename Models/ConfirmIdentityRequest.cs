    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConfirmIdentityRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConfirmIdentityRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ConfirmIdentityRequestType ConfirmIdentityRequest1;
        
        public ConfirmIdentityRequest()
        {
        }
        
        public ConfirmIdentityRequest(CustomSecurityHeaderType RequesterCredentials,ConfirmIdentityRequestType ConfirmIdentityRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ConfirmIdentityRequest1 = ConfirmIdentityRequest1;
        }
    }
