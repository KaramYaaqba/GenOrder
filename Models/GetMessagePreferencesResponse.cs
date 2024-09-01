    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessagePreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessagePreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMessagePreferencesResponseType GetMessagePreferencesResponse1;
        
        public GetMessagePreferencesResponse()
        {
        }
        
        public GetMessagePreferencesResponse(CustomSecurityHeaderType RequesterCredentials,GetMessagePreferencesResponseType GetMessagePreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMessagePreferencesResponse1 = GetMessagePreferencesResponse1;
        }
    }
