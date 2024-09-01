    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerTemplateAutomationRuleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerTemplateAutomationRuleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerTemplateAutomationRuleRequestType DeleteSellingManagerTemplateAutomationRuleRequest1;
        
        public DeleteSellingManagerTemplateAutomationRuleRequest()
        {
        }
        
        public DeleteSellingManagerTemplateAutomationRuleRequest(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerTemplateAutomationRuleRequestType DeleteSellingManagerTemplateAutomationRuleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerTemplateAutomationRuleRequest1 = DeleteSellingManagerTemplateAutomationRuleRequest1;
        }
    }
