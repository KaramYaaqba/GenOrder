    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseMyMessagesFoldersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseMyMessagesFoldersResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseMyMessagesFoldersResponseType ReviseMyMessagesFoldersResponse1;
        
        public ReviseMyMessagesFoldersResponse()
        {
        }
        
        public ReviseMyMessagesFoldersResponse(CustomSecurityHeaderType RequesterCredentials,ReviseMyMessagesFoldersResponseType ReviseMyMessagesFoldersResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseMyMessagesFoldersResponse1 = ReviseMyMessagesFoldersResponse1;
        }
    }
