    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerTemplateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerTemplateResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerTemplateResponseType AddSellingManagerTemplateResponse1;
        
        public AddSellingManagerTemplateResponse()
        {
        }
        
        public AddSellingManagerTemplateResponse(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerTemplateResponseType AddSellingManagerTemplateResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerTemplateResponse1 = AddSellingManagerTemplateResponse1;
        }
    }
