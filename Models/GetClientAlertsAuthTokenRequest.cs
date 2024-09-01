    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClientAlertsAuthTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClientAlertsAuthTokenRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetClientAlertsAuthTokenRequestType GetClientAlertsAuthTokenRequest1;
        
        public GetClientAlertsAuthTokenRequest()
        {
        }
        
        public GetClientAlertsAuthTokenRequest(CustomSecurityHeaderType RequesterCredentials,GetClientAlertsAuthTokenRequestType GetClientAlertsAuthTokenRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetClientAlertsAuthTokenRequest1 = GetClientAlertsAuthTokenRequest1;
        }
    }
