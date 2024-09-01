    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStorePreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStorePreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStorePreferencesRequestType SetStorePreferencesRequest1;
        
        public SetStorePreferencesRequest()
        {
        }
        
        public SetStorePreferencesRequest(CustomSecurityHeaderType RequesterCredentials,SetStorePreferencesRequestType SetStorePreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStorePreferencesRequest1 = SetStorePreferencesRequest1;
        }
    }
