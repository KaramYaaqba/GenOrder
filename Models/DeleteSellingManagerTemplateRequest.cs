    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerTemplateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerTemplateRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerTemplateRequestType DeleteSellingManagerTemplateRequest1;
        
        public DeleteSellingManagerTemplateRequest()
        {
        }
        
        public DeleteSellingManagerTemplateRequest(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerTemplateRequestType DeleteSellingManagerTemplateRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerTemplateRequest1 = DeleteSellingManagerTemplateRequest1;
        }
    }
