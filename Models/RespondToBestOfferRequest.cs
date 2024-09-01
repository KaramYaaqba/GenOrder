    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RespondToBestOfferRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RespondToBestOfferRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RespondToBestOfferRequestType RespondToBestOfferRequest1;
        
        public RespondToBestOfferRequest()
        {
        }
        
        public RespondToBestOfferRequest(CustomSecurityHeaderType RequesterCredentials,RespondToBestOfferRequestType RespondToBestOfferRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RespondToBestOfferRequest1 = RespondToBestOfferRequest1;
        }
    }
