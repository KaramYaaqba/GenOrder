    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToWatchListResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToWatchListResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddToWatchListResponseType AddToWatchListResponse1;
        
        public AddToWatchListResponse()
        {
        }
        
        public AddToWatchListResponse(CustomSecurityHeaderType RequesterCredentials,AddToWatchListResponseType AddToWatchListResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddToWatchListResponse1 = AddToWatchListResponse1;
        }
    }
