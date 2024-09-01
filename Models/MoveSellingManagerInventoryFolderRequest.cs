    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MoveSellingManagerInventoryFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MoveSellingManagerInventoryFolderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public MoveSellingManagerInventoryFolderRequestType MoveSellingManagerInventoryFolderRequest1;
        
        public MoveSellingManagerInventoryFolderRequest()
        {
        }
        
        public MoveSellingManagerInventoryFolderRequest(CustomSecurityHeaderType RequesterCredentials,MoveSellingManagerInventoryFolderRequestType MoveSellingManagerInventoryFolderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.MoveSellingManagerInventoryFolderRequest1 = MoveSellingManagerInventoryFolderRequest1;
        }
    }
