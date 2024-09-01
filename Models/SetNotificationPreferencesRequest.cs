    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetNotificationPreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetNotificationPreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetNotificationPreferencesRequestType SetNotificationPreferencesRequest1;
        
        public SetNotificationPreferencesRequest()
        {
        }
        
        public SetNotificationPreferencesRequest(CustomSecurityHeaderType RequesterCredentials,SetNotificationPreferencesRequestType SetNotificationPreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetNotificationPreferencesRequest1 = SetNotificationPreferencesRequest1;
        }
    }
