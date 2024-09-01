    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerDashboardResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerDashboardResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerDashboardResponseType GetSellerDashboardResponse1;
        
        public GetSellerDashboardResponse()
        {
        }
        
        public GetSellerDashboardResponse(CustomSecurityHeaderType RequesterCredentials,GetSellerDashboardResponseType GetSellerDashboardResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerDashboardResponse1 = GetSellerDashboardResponse1;
        }
    }
