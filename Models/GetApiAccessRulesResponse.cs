    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApiAccessRulesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApiAccessRulesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetApiAccessRulesResponseType GetApiAccessRulesResponse1;
        
        public GetApiAccessRulesResponse()
        {
        }
        
        public GetApiAccessRulesResponse(CustomSecurityHeaderType RequesterCredentials,GetApiAccessRulesResponseType GetApiAccessRulesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetApiAccessRulesResponse1 = GetApiAccessRulesResponse1;
        }
    }
