    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetPromotionalSaleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPromotionalSaleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetPromotionalSaleResponseType SetPromotionalSaleResponse1;
        
        public SetPromotionalSaleResponse()
        {
        }
        
        public SetPromotionalSaleResponse(CustomSecurityHeaderType RequesterCredentials,SetPromotionalSaleResponseType SetPromotionalSaleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetPromotionalSaleResponse1 = SetPromotionalSaleResponse1;
        }
    }
