    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SellerReverseDisputeResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SellerReverseDisputeResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SellerReverseDisputeResponseType SellerReverseDisputeResponse1;
        
        public SellerReverseDisputeResponse()
        {
        }
        
        public SellerReverseDisputeResponse(CustomSecurityHeaderType RequesterCredentials,SellerReverseDisputeResponseType SellerReverseDisputeResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SellerReverseDisputeResponse1 = SellerReverseDisputeResponse1;
        }
    }
