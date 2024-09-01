    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveFromWatchListRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveFromWatchListRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RemoveFromWatchListRequestType RemoveFromWatchListRequest1;
        
        public RemoveFromWatchListRequest()
        {
        }
        
        public RemoveFromWatchListRequest(CustomSecurityHeaderType RequesterCredentials,RemoveFromWatchListRequestType RemoveFromWatchListRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RemoveFromWatchListRequest1 = RemoveFromWatchListRequest1;
        }
    }
