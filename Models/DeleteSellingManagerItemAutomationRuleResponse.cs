    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerItemAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerItemAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerItemAutomationRuleResponseType DeleteSellingManagerItemAutomationRuleResponse1;
        
        public DeleteSellingManagerItemAutomationRuleResponse()
        {
        }
        
        public DeleteSellingManagerItemAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerItemAutomationRuleResponseType DeleteSellingManagerItemAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerItemAutomationRuleResponse1 = DeleteSellingManagerItemAutomationRuleResponse1;
        }
    }
