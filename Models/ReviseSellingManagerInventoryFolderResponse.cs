    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerInventoryFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerInventoryFolderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerInventoryFolderResponseType ReviseSellingManagerInventoryFolderResponse1;
        
        public ReviseSellingManagerInventoryFolderResponse()
        {
        }
        
        public ReviseSellingManagerInventoryFolderResponse(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerInventoryFolderResponseType ReviseSellingManagerInventoryFolderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerInventoryFolderResponse1 = ReviseSellingManagerInventoryFolderResponse1;
        }
    }
