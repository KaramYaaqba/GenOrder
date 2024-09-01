    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserPreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetUserPreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetUserPreferencesRequestType SetUserPreferencesRequest1;
        
        public SetUserPreferencesRequest()
        {
        }
        
        public SetUserPreferencesRequest(CustomSecurityHeaderType RequesterCredentials,SetUserPreferencesRequestType SetUserPreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetUserPreferencesRequest1 = SetUserPreferencesRequest1;
        }
    }
