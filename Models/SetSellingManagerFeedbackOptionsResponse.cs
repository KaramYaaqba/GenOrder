    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerFeedbackOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerFeedbackOptionsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerFeedbackOptionsResponseType SetSellingManagerFeedbackOptionsResponse1;
        
        public SetSellingManagerFeedbackOptionsResponse()
        {
        }
        
        public SetSellingManagerFeedbackOptionsResponse(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerFeedbackOptionsResponseType SetSellingManagerFeedbackOptionsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerFeedbackOptionsResponse1 = SetSellingManagerFeedbackOptionsResponse1;
        }
    }
