    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyAddItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyAddItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyAddItemRequestType VerifyAddItemRequest1;
        
        public VerifyAddItemRequest()
        {
        }
        
        public VerifyAddItemRequest(CustomSecurityHeaderType RequesterCredentials,VerifyAddItemRequestType VerifyAddItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyAddItemRequest1 = VerifyAddItemRequest1;
        }
    }
