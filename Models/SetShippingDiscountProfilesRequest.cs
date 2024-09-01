    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetShippingDiscountProfilesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetShippingDiscountProfilesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetShippingDiscountProfilesRequestType SetShippingDiscountProfilesRequest1;
        
        public SetShippingDiscountProfilesRequest()
        {
        }
        
        public SetShippingDiscountProfilesRequest(CustomSecurityHeaderType RequesterCredentials,SetShippingDiscountProfilesRequestType SetShippingDiscountProfilesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetShippingDiscountProfilesRequest1 = SetShippingDiscountProfilesRequest1;
        }
    }
