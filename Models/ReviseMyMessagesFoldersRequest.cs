    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseMyMessagesFoldersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseMyMessagesFoldersRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseMyMessagesFoldersRequestType ReviseMyMessagesFoldersRequest1;
        
        public ReviseMyMessagesFoldersRequest()
        {
        }
        
        public ReviseMyMessagesFoldersRequest(CustomSecurityHeaderType RequesterCredentials,ReviseMyMessagesFoldersRequestType ReviseMyMessagesFoldersRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseMyMessagesFoldersRequest1 = ReviseMyMessagesFoldersRequest1;
        }
    }
