    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrdersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrdersResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetOrdersResponseType GetOrdersResponse1;
        
        public GetOrdersResponse()
        {
        }
        
        public GetOrdersResponse(CustomSecurityHeaderType RequesterCredentials,GetOrdersResponseType GetOrdersResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetOrdersResponse1 = GetOrdersResponse1;
        }
    }
