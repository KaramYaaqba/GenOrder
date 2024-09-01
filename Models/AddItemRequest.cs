    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddItemRequestType AddItemRequest1;
        
        public AddItemRequest()
        {
        }
        
        public AddItemRequest(CustomSecurityHeaderType RequesterCredentials,AddItemRequestType AddItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddItemRequest1 = AddItemRequest1;
        }
    }
