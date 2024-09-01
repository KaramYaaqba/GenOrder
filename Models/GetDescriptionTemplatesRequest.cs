    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDescriptionTemplatesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDescriptionTemplatesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetDescriptionTemplatesRequestType GetDescriptionTemplatesRequest1;
        
        public GetDescriptionTemplatesRequest()
        {
        }
        
        public GetDescriptionTemplatesRequest(CustomSecurityHeaderType RequesterCredentials,GetDescriptionTemplatesRequestType GetDescriptionTemplatesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetDescriptionTemplatesRequest1 = GetDescriptionTemplatesRequest1;
        }
    }
