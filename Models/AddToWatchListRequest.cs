    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToWatchListRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToWatchListRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddToWatchListRequestType AddToWatchListRequest1;
        
        public AddToWatchListRequest()
        {
        }
        
        public AddToWatchListRequest(CustomSecurityHeaderType RequesterCredentials,AddToWatchListRequestType AddToWatchListRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddToWatchListRequest1 = AddToWatchListRequest1;
        }
    }
