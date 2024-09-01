    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemTransactionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemTransactionsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemTransactionsRequestType GetItemTransactionsRequest1;
        
        public GetItemTransactionsRequest()
        {
        }
        
        public GetItemTransactionsRequest(CustomSecurityHeaderType RequesterCredentials,GetItemTransactionsRequestType GetItemTransactionsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemTransactionsRequest1 = GetItemTransactionsRequest1;
        }
    }
