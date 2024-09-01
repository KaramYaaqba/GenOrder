    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteMyMessagesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteMyMessagesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteMyMessagesResponseType DeleteMyMessagesResponse1;
        
        public DeleteMyMessagesResponse()
        {
        }
        
        public DeleteMyMessagesResponse(CustomSecurityHeaderType RequesterCredentials,DeleteMyMessagesResponseType DeleteMyMessagesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteMyMessagesResponse1 = DeleteMyMessagesResponse1;
        }
    }
