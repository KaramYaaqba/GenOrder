    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerTemplateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerTemplateRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerTemplateRequestType AddSellingManagerTemplateRequest1;
        
        public AddSellingManagerTemplateRequest()
        {
        }
        
        public AddSellingManagerTemplateRequest(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerTemplateRequestType AddSellingManagerTemplateRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerTemplateRequest1 = AddSellingManagerTemplateRequest1;
        }
    }
