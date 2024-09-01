    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBestOffersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBestOffersRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetBestOffersRequestType GetBestOffersRequest1;
        
        public GetBestOffersRequest()
        {
        }
        
        public GetBestOffersRequest(CustomSecurityHeaderType RequesterCredentials,GetBestOffersRequestType GetBestOffersRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetBestOffersRequest1 = GetBestOffersRequest1;
        }
    }
