    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveItemToSellingManagerTemplateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveItemToSellingManagerTemplateRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SaveItemToSellingManagerTemplateRequestType SaveItemToSellingManagerTemplateRequest1;
        
        public SaveItemToSellingManagerTemplateRequest()
        {
        }
        
        public SaveItemToSellingManagerTemplateRequest(CustomSecurityHeaderType RequesterCredentials,SaveItemToSellingManagerTemplateRequestType SaveItemToSellingManagerTemplateRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SaveItemToSellingManagerTemplateRequest1 = SaveItemToSellingManagerTemplateRequest1;
        }
    }
