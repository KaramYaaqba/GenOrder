    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNotificationsUsageResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNotificationsUsageResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetNotificationsUsageResponseType GetNotificationsUsageResponse1;
        
        public GetNotificationsUsageResponse()
        {
        }
        
        public GetNotificationsUsageResponse(CustomSecurityHeaderType RequesterCredentials,GetNotificationsUsageResponseType GetNotificationsUsageResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetNotificationsUsageResponse1 = GetNotificationsUsageResponse1;
        }
    }
