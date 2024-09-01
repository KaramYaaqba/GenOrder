    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteMyMessagesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteMyMessagesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteMyMessagesRequestType DeleteMyMessagesRequest1;
        
        public DeleteMyMessagesRequest()
        {
        }
        
        public DeleteMyMessagesRequest(CustomSecurityHeaderType RequesterCredentials,DeleteMyMessagesRequestType DeleteMyMessagesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteMyMessagesRequest1 = DeleteMyMessagesRequest1;
        }
    }
