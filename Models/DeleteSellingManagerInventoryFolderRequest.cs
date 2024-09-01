    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerInventoryFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerInventoryFolderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerInventoryFolderRequestType DeleteSellingManagerInventoryFolderRequest1;
        
        public DeleteSellingManagerInventoryFolderRequest()
        {
        }
        
        public DeleteSellingManagerInventoryFolderRequest(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerInventoryFolderRequestType DeleteSellingManagerInventoryFolderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerInventoryFolderRequest1 = DeleteSellingManagerInventoryFolderRequest1;
        }
    }
