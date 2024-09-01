    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetBestOffersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetBestOffersResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetBestOffersResponseType GetBestOffersResponse1;
        
        public GetBestOffersResponse()
        {
        }
        
        public GetBestOffersResponse(CustomSecurityHeaderType RequesterCredentials,GetBestOffersResponseType GetBestOffersResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetBestOffersResponse1 = GetBestOffersResponse1;
        }
    }
