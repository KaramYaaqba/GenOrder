    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetShippingDiscountProfilesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetShippingDiscountProfilesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetShippingDiscountProfilesResponseType SetShippingDiscountProfilesResponse1;
        
        public SetShippingDiscountProfilesResponse()
        {
        }
        
        public SetShippingDiscountProfilesResponse(CustomSecurityHeaderType RequesterCredentials,SetShippingDiscountProfilesResponseType SetShippingDiscountProfilesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetShippingDiscountProfilesResponse1 = SetShippingDiscountProfilesResponse1;
        }
    }
