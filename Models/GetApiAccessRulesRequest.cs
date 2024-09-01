    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApiAccessRulesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApiAccessRulesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetApiAccessRulesRequestType GetApiAccessRulesRequest1;
        
        public GetApiAccessRulesRequest()
        {
        }
        
        public GetApiAccessRulesRequest(CustomSecurityHeaderType RequesterCredentials,GetApiAccessRulesRequestType GetApiAccessRulesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetApiAccessRulesRequest1 = GetApiAccessRulesRequest1;
        }
    }
