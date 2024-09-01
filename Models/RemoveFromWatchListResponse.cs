    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveFromWatchListResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveFromWatchListResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public RemoveFromWatchListResponseType RemoveFromWatchListResponse1;
        
        public RemoveFromWatchListResponse()
        {
        }
        
        public RemoveFromWatchListResponse(CustomSecurityHeaderType RequesterCredentials,RemoveFromWatchListResponseType RemoveFromWatchListResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.RemoveFromWatchListResponse1 = RemoveFromWatchListResponse1;
        }
    }
