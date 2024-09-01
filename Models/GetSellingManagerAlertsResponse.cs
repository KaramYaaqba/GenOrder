    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerAlertsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerAlertsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerAlertsResponseType GetSellingManagerAlertsResponse1;
        
        public GetSellingManagerAlertsResponse()
        {
        }
        
        public GetSellingManagerAlertsResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerAlertsResponseType GetSellingManagerAlertsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerAlertsResponse1 = GetSellingManagerAlertsResponse1;
        }
    }
