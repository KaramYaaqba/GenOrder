    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerSoldListingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerSoldListingsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerSoldListingsRequestType GetSellingManagerSoldListingsRequest1;
        
        public GetSellingManagerSoldListingsRequest()
        {
        }
        
        public GetSellingManagerSoldListingsRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerSoldListingsRequestType GetSellingManagerSoldListingsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerSoldListingsRequest1 = GetSellingManagerSoldListingsRequest1;
        }
    }
