    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPromotionalSaleDetailsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPromotionalSaleDetailsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetPromotionalSaleDetailsRequestType GetPromotionalSaleDetailsRequest1;
        
        public GetPromotionalSaleDetailsRequest()
        {
        }
        
        public GetPromotionalSaleDetailsRequest(CustomSecurityHeaderType RequesterCredentials,GetPromotionalSaleDetailsRequestType GetPromotionalSaleDetailsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetPromotionalSaleDetailsRequest1 = GetPromotionalSaleDetailsRequest1;
        }
    }
