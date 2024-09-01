    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RespondToFeedbackRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RespondToFeedbackRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RespondToFeedbackRequestType RespondToFeedbackRequest1;
        
        public RespondToFeedbackRequest()
        {
        }
        
        public RespondToFeedbackRequest(CustomSecurityHeaderType RequesterCredentials,RespondToFeedbackRequestType RespondToFeedbackRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RespondToFeedbackRequest1 = RespondToFeedbackRequest1;
        }
    }
