    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAdFormatLeadsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAdFormatLeadsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAdFormatLeadsResponseType GetAdFormatLeadsResponse1;
        
        public GetAdFormatLeadsResponse()
        {
        }
        
        public GetAdFormatLeadsResponse(CustomSecurityHeaderType RequesterCredentials,GetAdFormatLeadsResponseType GetAdFormatLeadsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAdFormatLeadsResponse1 = GetAdFormatLeadsResponse1;
        }
    }
