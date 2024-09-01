    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyeBayBuyingResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyeBayBuyingResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyeBayBuyingResponseType GetMyeBayBuyingResponse1;
        
        public GetMyeBayBuyingResponse()
        {
        }
        
        public GetMyeBayBuyingResponse(CustomSecurityHeaderType RequesterCredentials,GetMyeBayBuyingResponseType GetMyeBayBuyingResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyeBayBuyingResponse1 = GetMyeBayBuyingResponse1;
        }
    }
