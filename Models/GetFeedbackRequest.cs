    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFeedbackRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFeedbackRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetFeedbackRequestType GetFeedbackRequest1;
        
        public GetFeedbackRequest()
        {
        }
        
        public GetFeedbackRequest(CustomSecurityHeaderType RequesterCredentials,GetFeedbackRequestType GetFeedbackRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetFeedbackRequest1 = GetFeedbackRequest1;
        }
    }
