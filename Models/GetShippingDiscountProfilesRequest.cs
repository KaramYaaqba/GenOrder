    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShippingDiscountProfilesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShippingDiscountProfilesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetShippingDiscountProfilesRequestType GetShippingDiscountProfilesRequest1;
        
        public GetShippingDiscountProfilesRequest()
        {
        }
        
        public GetShippingDiscountProfilesRequest(CustomSecurityHeaderType RequesterCredentials,GetShippingDiscountProfilesRequestType GetShippingDiscountProfilesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetShippingDiscountProfilesRequest1 = GetShippingDiscountProfilesRequest1;
        }
    }
