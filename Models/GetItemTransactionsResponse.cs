    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemTransactionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemTransactionsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemTransactionsResponseType GetItemTransactionsResponse1;
        
        public GetItemTransactionsResponse()
        {
        }
        
        public GetItemTransactionsResponse(CustomSecurityHeaderType RequesterCredentials,GetItemTransactionsResponseType GetItemTransactionsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemTransactionsResponse1 = GetItemTransactionsResponse1;
        }
    }
