    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerTransactionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerTransactionsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerTransactionsRequestType GetSellerTransactionsRequest1;
        
        public GetSellerTransactionsRequest()
        {
        }
        
        public GetSellerTransactionsRequest(CustomSecurityHeaderType RequesterCredentials,GetSellerTransactionsRequestType GetSellerTransactionsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerTransactionsRequest1 = GetSellerTransactionsRequest1;
        }
    }
