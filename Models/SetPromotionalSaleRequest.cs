    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetPromotionalSaleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPromotionalSaleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetPromotionalSaleRequestType SetPromotionalSaleRequest1;
        
        public SetPromotionalSaleRequest()
        {
        }
        
        public SetPromotionalSaleRequest(CustomSecurityHeaderType RequesterCredentials,SetPromotionalSaleRequestType SetPromotionalSaleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetPromotionalSaleRequest1 = SetPromotionalSaleRequest1;
        }
    }
