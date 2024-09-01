    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNotificationsUsageRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNotificationsUsageRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetNotificationsUsageRequestType GetNotificationsUsageRequest1;
        
        public GetNotificationsUsageRequest()
        {
        }
        
        public GetNotificationsUsageRequest(CustomSecurityHeaderType RequesterCredentials,GetNotificationsUsageRequestType GetNotificationsUsageRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetNotificationsUsageRequest1 = GetNotificationsUsageRequest1;
        }
    }
