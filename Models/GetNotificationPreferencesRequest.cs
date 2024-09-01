    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNotificationPreferencesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNotificationPreferencesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetNotificationPreferencesRequestType GetNotificationPreferencesRequest1;
        
        public GetNotificationPreferencesRequest()
        {
        }
        
        public GetNotificationPreferencesRequest(CustomSecurityHeaderType RequesterCredentials,GetNotificationPreferencesRequestType GetNotificationPreferencesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetNotificationPreferencesRequest1 = GetNotificationPreferencesRequest1;
        }
    }
