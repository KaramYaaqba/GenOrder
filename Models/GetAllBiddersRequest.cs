    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBiddersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBiddersRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAllBiddersRequestType GetAllBiddersRequest1;
        
        public GetAllBiddersRequest()
        {
        }
        
        public GetAllBiddersRequest(CustomSecurityHeaderType RequesterCredentials,GetAllBiddersRequestType GetAllBiddersRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAllBiddersRequest1 = GetAllBiddersRequest1;
        }
    }
