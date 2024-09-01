    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStorePreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStorePreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStorePreferencesResponseType GetStorePreferencesResponse1;
        
        public GetStorePreferencesResponse()
        {
        }
        
        public GetStorePreferencesResponse(CustomSecurityHeaderType RequesterCredentials,GetStorePreferencesResponseType GetStorePreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStorePreferencesResponse1 = GetStorePreferencesResponse1;
        }
    }
