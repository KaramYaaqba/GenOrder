    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerItemAutomationRuleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerItemAutomationRuleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerItemAutomationRuleRequestType SetSellingManagerItemAutomationRuleRequest1;
        
        public SetSellingManagerItemAutomationRuleRequest()
        {
        }
        
        public SetSellingManagerItemAutomationRuleRequest(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerItemAutomationRuleRequestType SetSellingManagerItemAutomationRuleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerItemAutomationRuleRequest1 = SetSellingManagerItemAutomationRuleRequest1;
        }
    }
