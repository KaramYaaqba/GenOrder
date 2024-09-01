    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBiddersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBiddersResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAllBiddersResponseType GetAllBiddersResponse1;
        
        public GetAllBiddersResponse()
        {
        }
        
        public GetAllBiddersResponse(CustomSecurityHeaderType RequesterCredentials,GetAllBiddersResponseType GetAllBiddersResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAllBiddersResponse1 = GetAllBiddersResponse1;
        }
    }
