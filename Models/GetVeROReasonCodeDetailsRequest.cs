    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVeROReasonCodeDetailsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVeROReasonCodeDetailsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetVeROReasonCodeDetailsRequestType GetVeROReasonCodeDetailsRequest1;
        
        public GetVeROReasonCodeDetailsRequest()
        {
        }
        
        public GetVeROReasonCodeDetailsRequest(CustomSecurityHeaderType RequesterCredentials,GetVeROReasonCodeDetailsRequestType GetVeROReasonCodeDetailsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetVeROReasonCodeDetailsRequest1 = GetVeROReasonCodeDetailsRequest1;
        }
    }
