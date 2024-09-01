    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerifyAddSecondChanceItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerifyAddSecondChanceItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VerifyAddSecondChanceItemResponseType VerifyAddSecondChanceItemResponse1;
        
        public VerifyAddSecondChanceItemResponse()
        {
        }
        
        public VerifyAddSecondChanceItemResponse(CustomSecurityHeaderType RequesterCredentials,VerifyAddSecondChanceItemResponseType VerifyAddSecondChanceItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VerifyAddSecondChanceItemResponse1 = VerifyAddSecondChanceItemResponse1;
        }
    }
