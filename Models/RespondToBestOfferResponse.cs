    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RespondToBestOfferResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RespondToBestOfferResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RespondToBestOfferResponseType RespondToBestOfferResponse1;
        
        public RespondToBestOfferResponse()
        {
        }
        
        public RespondToBestOfferResponse(CustomSecurityHeaderType RequesterCredentials,RespondToBestOfferResponseType RespondToBestOfferResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RespondToBestOfferResponse1 = RespondToBestOfferResponse1;
        }
    }
