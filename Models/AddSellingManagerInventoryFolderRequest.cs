    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerInventoryFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerInventoryFolderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerInventoryFolderRequestType AddSellingManagerInventoryFolderRequest1;
        
        public AddSellingManagerInventoryFolderRequest()
        {
        }
        
        public AddSellingManagerInventoryFolderRequest(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerInventoryFolderRequestType AddSellingManagerInventoryFolderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerInventoryFolderRequest1 = AddSellingManagerInventoryFolderRequest1;
        }
    }
