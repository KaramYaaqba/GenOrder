    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBidderListResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBidderListResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetBidderListResponseType GetBidderListResponse1;
        
        public GetBidderListResponse()
        {
        }
        
        public GetBidderListResponse(CustomSecurityHeaderType RequesterCredentials,GetBidderListResponseType GetBidderListResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetBidderListResponse1 = GetBidderListResponse1;
        }
    }
