    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GeteBayDetailsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GeteBayDetailsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GeteBayDetailsRequestType GeteBayDetailsRequest1;
        
        public GeteBayDetailsRequest()
        {
        }
        
        public GeteBayDetailsRequest(CustomSecurityHeaderType RequesterCredentials,GeteBayDetailsRequestType GeteBayDetailsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GeteBayDetailsRequest1 = GeteBayDetailsRequest1;
        }
    }
