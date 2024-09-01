    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerSoldListingsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerSoldListingsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerSoldListingsResponseType GetSellingManagerSoldListingsResponse1;
        
        public GetSellingManagerSoldListingsResponse()
        {
        }
        
        public GetSellingManagerSoldListingsResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerSoldListingsResponseType GetSellingManagerSoldListingsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerSoldListingsResponse1 = GetSellingManagerSoldListingsResponse1;
        }
    }
