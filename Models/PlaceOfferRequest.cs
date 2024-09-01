    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PlaceOfferRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PlaceOfferRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public PlaceOfferRequestType PlaceOfferRequest1;
        
        public PlaceOfferRequest()
        {
        }
        
        public PlaceOfferRequest(CustomSecurityHeaderType RequesterCredentials,PlaceOfferRequestType PlaceOfferRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.PlaceOfferRequest1 = PlaceOfferRequest1;
        }
    }
