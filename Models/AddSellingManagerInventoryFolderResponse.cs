    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerInventoryFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerInventoryFolderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerInventoryFolderResponseType AddSellingManagerInventoryFolderResponse1;
        
        public AddSellingManagerInventoryFolderResponse()
        {
        }
        
        public AddSellingManagerInventoryFolderResponse(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerInventoryFolderResponseType AddSellingManagerInventoryFolderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerInventoryFolderResponse1 = AddSellingManagerInventoryFolderResponse1;
        }
    }
