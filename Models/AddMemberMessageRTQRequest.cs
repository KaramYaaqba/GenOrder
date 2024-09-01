    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMemberMessageRTQRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMemberMessageRTQRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddMemberMessageRTQRequestType AddMemberMessageRTQRequest1;
        
        public AddMemberMessageRTQRequest()
        {
        }
        
        public AddMemberMessageRTQRequest(CustomSecurityHeaderType RequesterCredentials,AddMemberMessageRTQRequestType AddMemberMessageRTQRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddMemberMessageRTQRequest1 = AddMemberMessageRTQRequest1;
        }
    }
