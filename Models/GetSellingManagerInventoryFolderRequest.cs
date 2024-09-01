    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerInventoryFolderRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerInventoryFolderRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerInventoryFolderRequestType GetSellingManagerInventoryFolderRequest1;
        
        public GetSellingManagerInventoryFolderRequest()
        {
        }
        
        public GetSellingManagerInventoryFolderRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerInventoryFolderRequestType GetSellingManagerInventoryFolderRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerInventoryFolderRequest1 = GetSellingManagerInventoryFolderRequest1;
        }
    }
