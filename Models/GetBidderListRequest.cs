    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBidderListRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBidderListRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetBidderListRequestType GetBidderListRequest1;
        
        public GetBidderListRequest()
        {
        }
        
        public GetBidderListRequest(CustomSecurityHeaderType RequesterCredentials,GetBidderListRequestType GetBidderListRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetBidderListRequest1 = GetBidderListRequest1;
        }
    }
