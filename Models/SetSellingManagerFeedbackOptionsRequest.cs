    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerFeedbackOptionsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerFeedbackOptionsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerFeedbackOptionsRequestType SetSellingManagerFeedbackOptionsRequest1;
        
        public SetSellingManagerFeedbackOptionsRequest()
        {
        }
        
        public SetSellingManagerFeedbackOptionsRequest(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerFeedbackOptionsRequestType SetSellingManagerFeedbackOptionsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerFeedbackOptionsRequest1 = SetSellingManagerFeedbackOptionsRequest1;
        }
    }
