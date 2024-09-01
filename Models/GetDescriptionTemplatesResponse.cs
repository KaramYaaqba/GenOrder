    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDescriptionTemplatesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDescriptionTemplatesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetDescriptionTemplatesResponseType GetDescriptionTemplatesResponse1;
        
        public GetDescriptionTemplatesResponse()
        {
        }
        
        public GetDescriptionTemplatesResponse(CustomSecurityHeaderType RequesterCredentials,GetDescriptionTemplatesResponseType GetDescriptionTemplatesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetDescriptionTemplatesResponse1 = GetDescriptionTemplatesResponse1;
        }
    }
