    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetPromotionalSaleListingsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPromotionalSaleListingsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetPromotionalSaleListingsRequestType SetPromotionalSaleListingsRequest1;
        
        public SetPromotionalSaleListingsRequest()
        {
        }
        
        public SetPromotionalSaleListingsRequest(CustomSecurityHeaderType RequesterCredentials,SetPromotionalSaleListingsRequestType SetPromotionalSaleListingsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetPromotionalSaleListingsRequest1 = SetPromotionalSaleListingsRequest1;
        }
    }
