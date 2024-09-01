    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerInventoryFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerInventoryFolderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerInventoryFolderResponseType DeleteSellingManagerInventoryFolderResponse1;
        
        public DeleteSellingManagerInventoryFolderResponse()
        {
        }
        
        public DeleteSellingManagerInventoryFolderResponse(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerInventoryFolderResponseType DeleteSellingManagerInventoryFolderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerInventoryFolderResponse1 = DeleteSellingManagerInventoryFolderResponse1;
        }
    }
