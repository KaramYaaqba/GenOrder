    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMemberMessageRTQResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMemberMessageRTQResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddMemberMessageRTQResponseType AddMemberMessageRTQResponse1;
        
        public AddMemberMessageRTQResponse()
        {
        }
        
        public AddMemberMessageRTQResponse(CustomSecurityHeaderType RequesterCredentials,AddMemberMessageRTQResponseType AddMemberMessageRTQResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddMemberMessageRTQResponse1 = AddMemberMessageRTQResponse1;
        }
    }
