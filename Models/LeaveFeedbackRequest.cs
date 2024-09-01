    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LeaveFeedbackRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LeaveFeedbackRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public LeaveFeedbackRequestType LeaveFeedbackRequest1;
        
        public LeaveFeedbackRequest()
        {
        }
        
        public LeaveFeedbackRequest(CustomSecurityHeaderType RequesterCredentials,LeaveFeedbackRequestType LeaveFeedbackRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.LeaveFeedbackRequest1 = LeaveFeedbackRequest1;
        }
    }
