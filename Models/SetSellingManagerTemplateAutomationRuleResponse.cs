    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerTemplateAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerTemplateAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerTemplateAutomationRuleResponseType SetSellingManagerTemplateAutomationRuleResponse1;
        
        public SetSellingManagerTemplateAutomationRuleResponse()
        {
        }
        
        public SetSellingManagerTemplateAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerTemplateAutomationRuleResponseType SetSellingManagerTemplateAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerTemplateAutomationRuleResponse1 = SetSellingManagerTemplateAutomationRuleResponse1;
        }
    }
