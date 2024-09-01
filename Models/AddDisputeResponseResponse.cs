    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDisputeResponseResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDisputeResponseResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddDisputeResponseResponseType AddDisputeResponseResponse1;
        
        public AddDisputeResponseResponse()
        {
        }
        
        public AddDisputeResponseResponse(CustomSecurityHeaderType RequesterCredentials,AddDisputeResponseResponseType AddDisputeResponseResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddDisputeResponseResponse1 = AddDisputeResponseResponse1;
        }
    }
