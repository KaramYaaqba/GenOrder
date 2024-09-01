    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RelistItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RelistItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RelistItemResponseType RelistItemResponse1;
        
        public RelistItemResponse()
        {
        }
        
        public RelistItemResponse(CustomSecurityHeaderType RequesterCredentials,RelistItemResponseType RelistItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RelistItemResponse1 = RelistItemResponse1;
        }
    }
