    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyeBaySellingResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyeBaySellingResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyeBaySellingResponseType GetMyeBaySellingResponse1;
        
        public GetMyeBaySellingResponse()
        {
        }
        
        public GetMyeBaySellingResponse(CustomSecurityHeaderType RequesterCredentials,GetMyeBaySellingResponseType GetMyeBaySellingResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyeBaySellingResponse1 = GetMyeBaySellingResponse1;
        }
    }
