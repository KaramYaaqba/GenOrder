    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerInventoryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerInventoryRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerInventoryRequestType GetSellingManagerInventoryRequest1;
        
        public GetSellingManagerInventoryRequest()
        {
        }
        
        public GetSellingManagerInventoryRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerInventoryRequestType GetSellingManagerInventoryRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerInventoryRequest1 = GetSellingManagerInventoryRequest1;
        }
    }
