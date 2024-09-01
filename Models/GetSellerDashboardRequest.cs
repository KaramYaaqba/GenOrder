    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerDashboardRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerDashboardRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerDashboardRequestType GetSellerDashboardRequest1;
        
        public GetSellerDashboardRequest()
        {
        }
        
        public GetSellerDashboardRequest(CustomSecurityHeaderType RequesterCredentials,GetSellerDashboardRequestType GetSellerDashboardRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerDashboardRequest1 = GetSellerDashboardRequest1;
        }
    }
