    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserPreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserPreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserPreferencesResponseType GetUserPreferencesResponse1;
        
        public GetUserPreferencesResponse()
        {
        }
        
        public GetUserPreferencesResponse(CustomSecurityHeaderType RequesterCredentials,GetUserPreferencesResponseType GetUserPreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserPreferencesResponse1 = GetUserPreferencesResponse1;
        }
    }
