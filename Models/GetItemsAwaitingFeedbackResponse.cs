    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemsAwaitingFeedbackResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemsAwaitingFeedbackResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemsAwaitingFeedbackResponseType GetItemsAwaitingFeedbackResponse1;
        
        public GetItemsAwaitingFeedbackResponse()
        {
        }
        
        public GetItemsAwaitingFeedbackResponse(CustomSecurityHeaderType RequesterCredentials,GetItemsAwaitingFeedbackResponseType GetItemsAwaitingFeedbackResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemsAwaitingFeedbackResponse1 = GetItemsAwaitingFeedbackResponse1;
        }
    }
