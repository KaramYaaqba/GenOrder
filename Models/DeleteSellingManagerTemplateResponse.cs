    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSellingManagerTemplateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSellingManagerTemplateResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public DeleteSellingManagerTemplateResponseType DeleteSellingManagerTemplateResponse1;
        
        public DeleteSellingManagerTemplateResponse()
        {
        }
        
        public DeleteSellingManagerTemplateResponse(CustomSecurityHeaderType RequesterCredentials,DeleteSellingManagerTemplateResponseType DeleteSellingManagerTemplateResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.DeleteSellingManagerTemplateResponse1 = DeleteSellingManagerTemplateResponse1;
        }
    }
