    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddItemFromSellingManagerTemplateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddItemFromSellingManagerTemplateResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddItemFromSellingManagerTemplateResponseType AddItemFromSellingManagerTemplateResponse1;
        
        public AddItemFromSellingManagerTemplateResponse()
        {
        }
        
        public AddItemFromSellingManagerTemplateResponse(CustomSecurityHeaderType RequesterCredentials,AddItemFromSellingManagerTemplateResponseType AddItemFromSellingManagerTemplateResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddItemFromSellingManagerTemplateResponse1 = AddItemFromSellingManagerTemplateResponse1;
        }
    }
