    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerInventoryFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerInventoryFolderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerInventoryFolderRequestType ReviseSellingManagerInventoryFolderRequest1;
        
        public ReviseSellingManagerInventoryFolderRequest()
        {
        }
        
        public ReviseSellingManagerInventoryFolderRequest(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerInventoryFolderRequestType ReviseSellingManagerInventoryFolderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerInventoryFolderRequest1 = ReviseSellingManagerInventoryFolderRequest1;
        }
    }
