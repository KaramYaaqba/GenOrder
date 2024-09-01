    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveItemToSellingManagerTemplateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveItemToSellingManagerTemplateResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SaveItemToSellingManagerTemplateResponseType SaveItemToSellingManagerTemplateResponse1;
        
        public SaveItemToSellingManagerTemplateResponse()
        {
        }
        
        public SaveItemToSellingManagerTemplateResponse(CustomSecurityHeaderType RequesterCredentials,SaveItemToSellingManagerTemplateResponseType SaveItemToSellingManagerTemplateResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SaveItemToSellingManagerTemplateResponse1 = SaveItemToSellingManagerTemplateResponse1;
        }
    }
