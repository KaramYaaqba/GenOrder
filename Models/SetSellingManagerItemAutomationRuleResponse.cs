    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerItemAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerItemAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerItemAutomationRuleResponseType SetSellingManagerItemAutomationRuleResponse1;
        
        public SetSellingManagerItemAutomationRuleResponse()
        {
        }
        
        public SetSellingManagerItemAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerItemAutomationRuleResponseType SetSellingManagerItemAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerItemAutomationRuleResponse1 = SetSellingManagerItemAutomationRuleResponse1;
        }
    }
