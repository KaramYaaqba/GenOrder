    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerAlertsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerAlertsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerAlertsRequestType GetSellingManagerAlertsRequest1;
        
        public GetSellingManagerAlertsRequest()
        {
        }
        
        public GetSellingManagerAlertsRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerAlertsRequestType GetSellingManagerAlertsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerAlertsRequest1 = GetSellingManagerAlertsRequest1;
        }
    }
