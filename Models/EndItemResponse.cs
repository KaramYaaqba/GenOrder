    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EndItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EndItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public EndItemResponseType EndItemResponse1;
        
        public EndItemResponse()
        {
        }
        
        public EndItemResponse(CustomSecurityHeaderType RequesterCredentials,EndItemResponseType EndItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.EndItemResponse1 = EndItemResponse1;
        }
    }
