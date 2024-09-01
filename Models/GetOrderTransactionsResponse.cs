    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderTransactionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrderTransactionsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetOrderTransactionsResponseType GetOrderTransactionsResponse1;
        
        public GetOrderTransactionsResponse()
        {
        }
        
        public GetOrderTransactionsResponse(CustomSecurityHeaderType RequesterCredentials,GetOrderTransactionsResponseType GetOrderTransactionsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetOrderTransactionsResponse1 = GetOrderTransactionsResponse1;
        }
    }
