    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerTemplateAutomationRuleResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerTemplateAutomationRuleResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerTemplateAutomationRuleResponseType DeleteSellingManagerTemplateAutomationRuleResponse1;
        
        public DeleteSellingManagerTemplateAutomationRuleResponse()
        {
        }
        
        public DeleteSellingManagerTemplateAutomationRuleResponse(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerTemplateAutomationRuleResponseType DeleteSellingManagerTemplateAutomationRuleResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerTemplateAutomationRuleResponse1 = DeleteSellingManagerTemplateAutomationRuleResponse1;
        }
    }
