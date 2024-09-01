    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseMyMessagesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseMyMessagesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseMyMessagesResponseType ReviseMyMessagesResponse1;
        
        public ReviseMyMessagesResponse()
        {
        }
        
        public ReviseMyMessagesResponse(CustomSecurityHeaderType RequesterCredentials,ReviseMyMessagesResponseType ReviseMyMessagesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseMyMessagesResponse1 = ReviseMyMessagesResponse1;
        }
    }
