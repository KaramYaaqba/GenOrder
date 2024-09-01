    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoveSellingManagerInventoryFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoveSellingManagerInventoryFolderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public MoveSellingManagerInventoryFolderResponseType MoveSellingManagerInventoryFolderResponse1;
        
        public MoveSellingManagerInventoryFolderResponse()
        {
        }
        
        public MoveSellingManagerInventoryFolderResponse(CustomSecurityHeaderType RequesterCredentials,MoveSellingManagerInventoryFolderResponseType MoveSellingManagerInventoryFolderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.MoveSellingManagerInventoryFolderResponse1 = MoveSellingManagerInventoryFolderResponse1;
        }
    }
