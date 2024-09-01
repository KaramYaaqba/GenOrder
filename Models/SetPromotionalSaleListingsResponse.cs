    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetPromotionalSaleListingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPromotionalSaleListingsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetPromotionalSaleListingsResponseType SetPromotionalSaleListingsResponse1;
        
        public SetPromotionalSaleListingsResponse()
        {
        }
        
        public SetPromotionalSaleListingsResponse(CustomSecurityHeaderType RequesterCredentials,SetPromotionalSaleListingsResponseType SetPromotionalSaleListingsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetPromotionalSaleListingsResponse1 = SetPromotionalSaleListingsResponse1;
        }
    }
