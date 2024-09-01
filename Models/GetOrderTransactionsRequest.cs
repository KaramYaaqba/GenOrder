    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderTransactionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrderTransactionsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetOrderTransactionsRequestType GetOrderTransactionsRequest1;
        
        public GetOrderTransactionsRequest()
        {
        }
        
        public GetOrderTransactionsRequest(CustomSecurityHeaderType RequesterCredentials,GetOrderTransactionsRequestType GetOrderTransactionsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetOrderTransactionsRequest1 = GetOrderTransactionsRequest1;
        }
    }
