    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseMyMessagesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseMyMessagesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseMyMessagesRequestType ReviseMyMessagesRequest1;
        
        public ReviseMyMessagesRequest()
        {
        }
        
        public ReviseMyMessagesRequest(CustomSecurityHeaderType RequesterCredentials,ReviseMyMessagesRequestType ReviseMyMessagesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseMyMessagesRequest1 = ReviseMyMessagesRequest1;
        }
    }
