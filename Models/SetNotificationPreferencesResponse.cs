    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetNotificationPreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetNotificationPreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetNotificationPreferencesResponseType SetNotificationPreferencesResponse1;
        
        public SetNotificationPreferencesResponse()
        {
        }
        
        public SetNotificationPreferencesResponse(CustomSecurityHeaderType RequesterCredentials,SetNotificationPreferencesResponseType SetNotificationPreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetNotificationPreferencesResponse1 = SetNotificationPreferencesResponse1;
        }
    }
