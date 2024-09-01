    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyAddItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyAddItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyAddItemResponseType VerifyAddItemResponse1;
        
        public VerifyAddItemResponse()
        {
        }
        
        public VerifyAddItemResponse(CustomSecurityHeaderType RequesterCredentials,VerifyAddItemResponseType VerifyAddItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyAddItemResponse1 = VerifyAddItemResponse1;
        }
    }
