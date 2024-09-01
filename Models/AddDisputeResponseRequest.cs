    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDisputeResponseRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDisputeResponseRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddDisputeResponseRequestType AddDisputeResponseRequest1;
        
        public AddDisputeResponseRequest()
        {
        }
        
        public AddDisputeResponseRequest(CustomSecurityHeaderType RequesterCredentials,AddDisputeResponseRequestType AddDisputeResponseRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddDisputeResponseRequest1 = AddDisputeResponseRequest1;
        }
    }
