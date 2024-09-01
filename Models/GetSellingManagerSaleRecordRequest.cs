    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerSaleRecordRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerSaleRecordRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerSaleRecordRequestType GetSellingManagerSaleRecordRequest1;
        
        public GetSellingManagerSaleRecordRequest()
        {
        }
        
        public GetSellingManagerSaleRecordRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerSaleRecordRequestType GetSellingManagerSaleRecordRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerSaleRecordRequest1 = GetSellingManagerSaleRecordRequest1;
        }
    }
