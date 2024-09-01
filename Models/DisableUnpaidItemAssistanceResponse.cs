    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DisableUnpaidItemAssistanceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DisableUnpaidItemAssistanceResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DisableUnpaidItemAssistanceResponseType DisableUnpaidItemAssistanceResponse1;
        
        public DisableUnpaidItemAssistanceResponse()
        {
        }
        
        public DisableUnpaidItemAssistanceResponse(CustomSecurityHeaderType RequesterCredentials,DisableUnpaidItemAssistanceResponseType DisableUnpaidItemAssistanceResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DisableUnpaidItemAssistanceResponse1 = DisableUnpaidItemAssistanceResponse1;
        }
    }
