    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerEventsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerEventsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerEventsRequestType GetSellerEventsRequest1;
        
        public GetSellerEventsRequest()
        {
        }
        
        public GetSellerEventsRequest(CustomSecurityHeaderType RequesterCredentials,GetSellerEventsRequestType GetSellerEventsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerEventsRequest1 = GetSellerEventsRequest1;
        }
    }
