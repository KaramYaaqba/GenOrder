    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSessionIDRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSessionIDRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSessionIDRequestType GetSessionIDRequest1;
        
        public GetSessionIDRequest()
        {
        }
        
        public GetSessionIDRequest(CustomSecurityHeaderType RequesterCredentials,GetSessionIDRequestType GetSessionIDRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSessionIDRequest1 = GetSessionIDRequest1;
        }
    }
