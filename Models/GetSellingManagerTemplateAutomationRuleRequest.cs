    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerTemplateAutomationRuleRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerTemplateAutomationRuleRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerTemplateAutomationRuleRequestType GetSellingManagerTemplateAutomationRuleRequest1;
        
        public GetSellingManagerTemplateAutomationRuleRequest()
        {
        }
        
        public GetSellingManagerTemplateAutomationRuleRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerTemplateAutomationRuleRequestType GetSellingManagerTemplateAutomationRuleRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerTemplateAutomationRuleRequest1 = GetSellingManagerTemplateAutomationRuleRequest1;
        }
    }
