    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerTemplateAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerTemplateAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerTemplateAutomationRuleResponseType GetSellingManagerTemplateAutomationRuleResponse1;
        
        public GetSellingManagerTemplateAutomationRuleResponse()
        {
        }
        
        public GetSellingManagerTemplateAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerTemplateAutomationRuleResponseType GetSellingManagerTemplateAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerTemplateAutomationRuleResponse1 = GetSellingManagerTemplateAutomationRuleResponse1;
        }
    }
