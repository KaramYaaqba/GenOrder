    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserResponseType GetUserResponse1;
        
        public GetUserResponse()
        {
        }
        
        public GetUserResponse(CustomSecurityHeaderType RequesterCredentials,GetUserResponseType GetUserResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserResponse1 = GetUserResponse1;
        }
    }
