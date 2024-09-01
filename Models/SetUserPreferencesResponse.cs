    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserPreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetUserPreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetUserPreferencesResponseType SetUserPreferencesResponse1;
        
        public SetUserPreferencesResponse()
        {
        }
        
        public SetUserPreferencesResponse(CustomSecurityHeaderType RequesterCredentials,SetUserPreferencesResponseType SetUserPreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetUserPreferencesResponse1 = SetUserPreferencesResponse1;
        }
    }
