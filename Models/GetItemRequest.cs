    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemRequestType GetItemRequest1;
        
        public GetItemRequest()
        {
        }
        
        public GetItemRequest(CustomSecurityHeaderType RequesterCredentials,GetItemRequestType GetItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemRequest1 = GetItemRequest1;
        }
    }
