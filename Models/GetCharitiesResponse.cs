    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCharitiesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCharitiesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCharitiesResponseType GetCharitiesResponse1;
        
        public GetCharitiesResponse()
        {
        }
        
        public GetCharitiesResponse(CustomSecurityHeaderType RequesterCredentials,GetCharitiesResponseType GetCharitiesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCharitiesResponse1 = GetCharitiesResponse1;
        }
    }
