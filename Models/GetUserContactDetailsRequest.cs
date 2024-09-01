    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserContactDetailsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserContactDetailsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserContactDetailsRequestType GetUserContactDetailsRequest1;
        
        public GetUserContactDetailsRequest()
        {
        }
        
        public GetUserContactDetailsRequest(CustomSecurityHeaderType RequesterCredentials,GetUserContactDetailsRequestType GetUserContactDetailsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserContactDetailsRequest1 = GetUserContactDetailsRequest1;
        }
    }
