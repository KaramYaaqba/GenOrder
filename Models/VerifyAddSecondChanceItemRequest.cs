    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyAddSecondChanceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyAddSecondChanceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyAddSecondChanceItemRequestType VerifyAddSecondChanceItemRequest1;
        
        public VerifyAddSecondChanceItemRequest()
        {
        }
        
        public VerifyAddSecondChanceItemRequest(CustomSecurityHeaderType RequesterCredentials,VerifyAddSecondChanceItemRequestType VerifyAddSecondChanceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyAddSecondChanceItemRequest1 = VerifyAddSecondChanceItemRequest1;
        }
    }
