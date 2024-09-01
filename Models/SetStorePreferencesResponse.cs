    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStorePreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStorePreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStorePreferencesResponseType SetStorePreferencesResponse1;
        
        public SetStorePreferencesResponse()
        {
        }
        
        public SetStorePreferencesResponse(CustomSecurityHeaderType RequesterCredentials,SetStorePreferencesResponseType SetStorePreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStorePreferencesResponse1 = SetStorePreferencesResponse1;
        }
    }
