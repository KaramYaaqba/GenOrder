    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetShippingDiscountProfilesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetShippingDiscountProfilesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetShippingDiscountProfilesResponseType GetShippingDiscountProfilesResponse1;
        
        public GetShippingDiscountProfilesResponse()
        {
        }
        
        public GetShippingDiscountProfilesResponse(CustomSecurityHeaderType RequesterCredentials,GetShippingDiscountProfilesResponseType GetShippingDiscountProfilesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetShippingDiscountProfilesResponse1 = GetShippingDiscountProfilesResponse1;
        }
    }
