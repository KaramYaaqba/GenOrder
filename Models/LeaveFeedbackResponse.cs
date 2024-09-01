    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LeaveFeedbackResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LeaveFeedbackResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public LeaveFeedbackResponseType LeaveFeedbackResponse1;
        
        public LeaveFeedbackResponse()
        {
        }
        
        public LeaveFeedbackResponse(CustomSecurityHeaderType RequesterCredentials,LeaveFeedbackResponseType LeaveFeedbackResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.LeaveFeedbackResponse1 = LeaveFeedbackResponse1;
        }
    }
