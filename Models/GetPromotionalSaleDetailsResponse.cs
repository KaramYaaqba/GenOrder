    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPromotionalSaleDetailsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPromotionalSaleDetailsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetPromotionalSaleDetailsResponseType GetPromotionalSaleDetailsResponse1;
        
        public GetPromotionalSaleDetailsResponse()
        {
        }
        
        public GetPromotionalSaleDetailsResponse(CustomSecurityHeaderType RequesterCredentials,GetPromotionalSaleDetailsResponseType GetPromotionalSaleDetailsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetPromotionalSaleDetailsResponse1 = GetPromotionalSaleDetailsResponse1;
        }
    }
