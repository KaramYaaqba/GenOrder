    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerTemplateResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerTemplateResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerTemplateResponseType ReviseSellingManagerTemplateResponse1;
        
        public ReviseSellingManagerTemplateResponse()
        {
        }
        
        public ReviseSellingManagerTemplateResponse(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerTemplateResponseType ReviseSellingManagerTemplateResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerTemplateResponse1 = ReviseSellingManagerTemplateResponse1;
        }
    }
