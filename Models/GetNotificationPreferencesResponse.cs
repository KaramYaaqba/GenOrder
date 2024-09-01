    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNotificationPreferencesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNotificationPreferencesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetNotificationPreferencesResponseType GetNotificationPreferencesResponse1;
        
        public GetNotificationPreferencesResponse()
        {
        }
        
        public GetNotificationPreferencesResponse(CustomSecurityHeaderType RequesterCredentials,GetNotificationPreferencesResponseType GetNotificationPreferencesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetNotificationPreferencesResponse1 = GetNotificationPreferencesResponse1;
        }
    }
