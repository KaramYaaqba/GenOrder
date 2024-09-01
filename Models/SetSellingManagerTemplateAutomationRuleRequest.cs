    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetSellingManagerTemplateAutomationRuleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetSellingManagerTemplateAutomationRuleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetSellingManagerTemplateAutomationRuleRequestType SetSellingManagerTemplateAutomationRuleRequest1;
        
        public SetSellingManagerTemplateAutomationRuleRequest()
        {
        }
        
        public SetSellingManagerTemplateAutomationRuleRequest(CustomSecurityHeaderType RequesterCredentials,SetSellingManagerTemplateAutomationRuleRequestType SetSellingManagerTemplateAutomationRuleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetSellingManagerTemplateAutomationRuleRequest1 = SetSellingManagerTemplateAutomationRuleRequest1;
        }
    }
