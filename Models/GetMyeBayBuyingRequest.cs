    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyeBayBuyingRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyeBayBuyingRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyeBayBuyingRequestType GetMyeBayBuyingRequest1;
        
        public GetMyeBayBuyingRequest()
        {
        }
        
        public GetMyeBayBuyingRequest(CustomSecurityHeaderType RequesterCredentials,GetMyeBayBuyingRequestType GetMyeBayBuyingRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyeBayBuyingRequest1 = GetMyeBayBuyingRequest1;
        }
    }
