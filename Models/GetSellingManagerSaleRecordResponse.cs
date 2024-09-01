    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerSaleRecordResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerSaleRecordResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerSaleRecordResponseType GetSellingManagerSaleRecordResponse1;
        
        public GetSellingManagerSaleRecordResponse()
        {
        }
        
        public GetSellingManagerSaleRecordResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerSaleRecordResponseType GetSellingManagerSaleRecordResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerSaleRecordResponse1 = GetSellingManagerSaleRecordResponse1;
        }
    }
