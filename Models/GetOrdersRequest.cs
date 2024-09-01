    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrdersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrdersRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetOrdersRequestType GetOrdersRequest1;
        
        public GetOrdersRequest()
        {
        }
        
        public GetOrdersRequest(CustomSecurityHeaderType RequesterCredentials,GetOrdersRequestType GetOrdersRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetOrdersRequest1 = GetOrdersRequest1;
        }
    }
