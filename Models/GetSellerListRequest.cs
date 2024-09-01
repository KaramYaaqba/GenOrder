    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerListRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerListRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerListRequestType GetSellerListRequest1;
        
        public GetSellerListRequest()
        {
        }
        
        public GetSellerListRequest(CustomSecurityHeaderType RequesterCredentials,GetSellerListRequestType GetSellerListRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerListRequest1 = GetSellerListRequest1;
        }
    }
