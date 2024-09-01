    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSessionIDResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSessionIDResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSessionIDResponseType GetSessionIDResponse1;
        
        public GetSessionIDResponse()
        {
        }
        
        public GetSessionIDResponse(CustomSecurityHeaderType RequesterCredentials,GetSessionIDResponseType GetSessionIDResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSessionIDResponse1 = GetSessionIDResponse1;
        }
    }
