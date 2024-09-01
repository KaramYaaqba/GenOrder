    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellerListResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellerListResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellerListResponseType GetSellerListResponse1;
        
        public GetSellerListResponse()
        {
        }
        
        public GetSellerListResponse(CustomSecurityHeaderType RequesterCredentials,GetSellerListResponseType GetSellerListResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellerListResponse1 = GetSellerListResponse1;
        }
    }
