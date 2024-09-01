    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserDisputesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserDisputesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserDisputesResponseType GetUserDisputesResponse1;
        
        public GetUserDisputesResponse()
        {
        }
        
        public GetUserDisputesResponse(CustomSecurityHeaderType RequesterCredentials,GetUserDisputesResponseType GetUserDisputesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserDisputesResponse1 = GetUserDisputesResponse1;
        }
    }
