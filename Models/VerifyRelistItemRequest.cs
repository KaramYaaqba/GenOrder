    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyRelistItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyRelistItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyRelistItemRequestType VerifyRelistItemRequest1;
        
        public VerifyRelistItemRequest()
        {
        }
        
        public VerifyRelistItemRequest(CustomSecurityHeaderType RequesterCredentials,VerifyRelistItemRequestType VerifyRelistItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyRelistItemRequest1 = VerifyRelistItemRequest1;
        }
    }
