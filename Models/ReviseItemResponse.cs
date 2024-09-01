    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseItemResponseType ReviseItemResponse1;
        
        public ReviseItemResponse()
        {
        }
        
        public ReviseItemResponse(CustomSecurityHeaderType RequesterCredentials,ReviseItemResponseType ReviseItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseItemResponse1 = ReviseItemResponse1;
        }
    }
