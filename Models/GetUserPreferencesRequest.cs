    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserPreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserPreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserPreferencesRequestType GetUserPreferencesRequest1;
        
        public GetUserPreferencesRequest()
        {
        }
        
        public GetUserPreferencesRequest(CustomSecurityHeaderType RequesterCredentials,GetUserPreferencesRequestType GetUserPreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserPreferencesRequest1 = GetUserPreferencesRequest1;
        }
    }
