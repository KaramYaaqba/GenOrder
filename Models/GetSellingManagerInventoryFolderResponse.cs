    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerInventoryFolderResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerInventoryFolderResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerInventoryFolderResponseType GetSellingManagerInventoryFolderResponse1;
        
        public GetSellingManagerInventoryFolderResponse()
        {
        }
        
        public GetSellingManagerInventoryFolderResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerInventoryFolderResponseType GetSellingManagerInventoryFolderResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerInventoryFolderResponse1 = GetSellingManagerInventoryFolderResponse1;
        }
    }
