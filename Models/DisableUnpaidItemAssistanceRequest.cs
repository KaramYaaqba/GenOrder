    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DisableUnpaidItemAssistanceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DisableUnpaidItemAssistanceRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DisableUnpaidItemAssistanceRequestType DisableUnpaidItemAssistanceRequest1;
        
        public DisableUnpaidItemAssistanceRequest()
        {
        }
        
        public DisableUnpaidItemAssistanceRequest(CustomSecurityHeaderType RequesterCredentials,DisableUnpaidItemAssistanceRequestType DisableUnpaidItemAssistanceRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DisableUnpaidItemAssistanceRequest1 = DisableUnpaidItemAssistanceRequest1;
        }
    }
