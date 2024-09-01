    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetMessagePreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetMessagePreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetMessagePreferencesRequestType SetMessagePreferencesRequest1;
        
        public SetMessagePreferencesRequest()
        {
        }
        
        public SetMessagePreferencesRequest(CustomSecurityHeaderType RequesterCredentials,SetMessagePreferencesRequestType SetMessagePreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetMessagePreferencesRequest1 = SetMessagePreferencesRequest1;
        }
    }
