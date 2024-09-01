    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PlaceOfferResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PlaceOfferResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public PlaceOfferResponseType PlaceOfferResponse1;
        
        public PlaceOfferResponse()
        {
        }
        
        public PlaceOfferResponse(CustomSecurityHeaderType RequesterCredentials,PlaceOfferResponseType PlaceOfferResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.PlaceOfferResponse1 = PlaceOfferResponse1;
        }
    }
