    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAdFormatLeadsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAdFormatLeadsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAdFormatLeadsRequestType GetAdFormatLeadsRequest1;
        
        public GetAdFormatLeadsRequest()
        {
        }
        
        public GetAdFormatLeadsRequest(CustomSecurityHeaderType RequesterCredentials,GetAdFormatLeadsRequestType GetAdFormatLeadsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAdFormatLeadsRequest1 = GetAdFormatLeadsRequest1;
        }
    }
