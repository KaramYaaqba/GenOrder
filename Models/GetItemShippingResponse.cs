    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemShippingResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemShippingResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemShippingResponseType GetItemShippingResponse1;
        
        public GetItemShippingResponse()
        {
        }
        
        public GetItemShippingResponse(CustomSecurityHeaderType RequesterCredentials,GetItemShippingResponseType GetItemShippingResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemShippingResponse1 = GetItemShippingResponse1;
        }
    }
