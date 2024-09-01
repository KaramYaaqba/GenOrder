    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCharitiesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCharitiesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCharitiesRequestType GetCharitiesRequest1;
        
        public GetCharitiesRequest()
        {
        }
        
        public GetCharitiesRequest(CustomSecurityHeaderType RequesterCredentials,GetCharitiesRequestType GetCharitiesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCharitiesRequest1 = GetCharitiesRequest1;
        }
    }
