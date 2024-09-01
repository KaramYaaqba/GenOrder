    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddItemsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddItemsRequestType AddItemsRequest1;
        
        public AddItemsRequest()
        {
        }
        
        public AddItemsRequest(CustomSecurityHeaderType RequesterCredentials,AddItemsRequestType AddItemsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddItemsRequest1 = AddItemsRequest1;
        }
    }
