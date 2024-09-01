    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerItemAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerItemAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerItemAutomationRuleResponseType GetSellingManagerItemAutomationRuleResponse1;
        
        public GetSellingManagerItemAutomationRuleResponse()
        {
        }
        
        public GetSellingManagerItemAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerItemAutomationRuleResponseType GetSellingManagerItemAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerItemAutomationRuleResponse1 = GetSellingManagerItemAutomationRuleResponse1;
        }
    }
