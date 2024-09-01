    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerTemplatesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerTemplatesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerTemplatesRequestType GetSellingManagerTemplatesRequest1;
        
        public GetSellingManagerTemplatesRequest()
        {
        }
        
        public GetSellingManagerTemplatesRequest(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerTemplatesRequestType GetSellingManagerTemplatesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerTemplatesRequest1 = GetSellingManagerTemplatesRequest1;
        }
    }
