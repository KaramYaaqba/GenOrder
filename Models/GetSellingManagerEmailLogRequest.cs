    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerEmailLogRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerEmailLogRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerEmailLogRequestType GetSellingManagerEmailLogRequest1;
        
        public GetSellingManagerEmailLogRequest()
        {
        }
        
        public GetSellingManagerEmailLogRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerEmailLogRequestType GetSellingManagerEmailLogRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerEmailLogRequest1 = GetSellingManagerEmailLogRequest1;
        }
    }
