    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConfirmIdentityResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConfirmIdentityResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ConfirmIdentityResponseType ConfirmIdentityResponse1;
        
        public ConfirmIdentityResponse()
        {
        }
        
        public ConfirmIdentityResponse(CustomSecurityHeaderType RequesterCredentials,ConfirmIdentityResponseType ConfirmIdentityResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ConfirmIdentityResponse1 = ConfirmIdentityResponse1;
        }
    }
