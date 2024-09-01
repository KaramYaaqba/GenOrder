    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerEventsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerEventsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerEventsResponseType GetSellerEventsResponse1;
        
        public GetSellerEventsResponse()
        {
        }
        
        public GetSellerEventsResponse(CustomSecurityHeaderType RequesterCredentials,GetSellerEventsResponseType GetSellerEventsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerEventsResponse1 = GetSellerEventsResponse1;
        }
    }
