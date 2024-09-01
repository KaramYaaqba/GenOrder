    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SellerReverseDisputeRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SellerReverseDisputeRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SellerReverseDisputeRequestType SellerReverseDisputeRequest1;
        
        public SellerReverseDisputeRequest()
        {
        }
        
        public SellerReverseDisputeRequest(CustomSecurityHeaderType RequesterCredentials,SellerReverseDisputeRequestType SellerReverseDisputeRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SellerReverseDisputeRequest1 = SellerReverseDisputeRequest1;
        }
    }
