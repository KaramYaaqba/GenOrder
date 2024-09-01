    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddItemFromSellingManagerTemplateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddItemFromSellingManagerTemplateRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddItemFromSellingManagerTemplateRequestType AddItemFromSellingManagerTemplateRequest1;
        
        public AddItemFromSellingManagerTemplateRequest()
        {
        }
        
        public AddItemFromSellingManagerTemplateRequest(CustomSecurityHeaderType RequesterCredentials,AddItemFromSellingManagerTemplateRequestType AddItemFromSellingManagerTemplateRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddItemFromSellingManagerTemplateRequest1 = AddItemFromSellingManagerTemplateRequest1;
        }
    }
