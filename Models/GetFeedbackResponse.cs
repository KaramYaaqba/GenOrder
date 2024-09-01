    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFeedbackResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFeedbackResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetFeedbackResponseType GetFeedbackResponse1;
        
        public GetFeedbackResponse()
        {
        }
        
        public GetFeedbackResponse(CustomSecurityHeaderType RequesterCredentials,GetFeedbackResponseType GetFeedbackResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetFeedbackResponse1 = GetFeedbackResponse1;
        }
    }
