    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerTransactionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerTransactionsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerTransactionsResponseType GetSellerTransactionsResponse1;
        
        public GetSellerTransactionsResponse()
        {
        }
        
        public GetSellerTransactionsResponse(CustomSecurityHeaderType RequesterCredentials,GetSellerTransactionsResponseType GetSellerTransactionsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerTransactionsResponse1 = GetSellerTransactionsResponse1;
        }
    }
