    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMessagePreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMessagePreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMessagePreferencesRequestType GetMessagePreferencesRequest1;
        
        public GetMessagePreferencesRequest()
        {
        }
        
        public GetMessagePreferencesRequest(CustomSecurityHeaderType RequesterCredentials, GetMessagePreferencesRequestType GetMessagePreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMessagePreferencesRequest1 = GetMessagePreferencesRequest1;
        }
    }
