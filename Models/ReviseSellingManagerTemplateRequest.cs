    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerTemplateRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerTemplateRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerTemplateRequestType ReviseSellingManagerTemplateRequest1;
        
        public ReviseSellingManagerTemplateRequest()
        {
        }
        
        public ReviseSellingManagerTemplateRequest(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerTemplateRequestType ReviseSellingManagerTemplateRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerTemplateRequest1 = ReviseSellingManagerTemplateRequest1;
        }
    }
