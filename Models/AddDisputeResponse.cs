    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDisputeResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDisputeResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddDisputeResponseType AddDisputeResponse1;
        
        public AddDisputeResponse()
        {
        }
        
        public AddDisputeResponse(CustomSecurityHeaderType RequesterCredentials,AddDisputeResponseType AddDisputeResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddDisputeResponse1 = AddDisputeResponse1;
        }
    }
