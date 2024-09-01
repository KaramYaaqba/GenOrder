    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateTestUserRegistrationRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateTestUserRegistrationRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ValidateTestUserRegistrationRequestType ValidateTestUserRegistrationRequest1;
        
        public ValidateTestUserRegistrationRequest()
        {
        }
        
        public ValidateTestUserRegistrationRequest(CustomSecurityHeaderType RequesterCredentials,ValidateTestUserRegistrationRequestType ValidateTestUserRegistrationRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ValidateTestUserRegistrationRequest1 = ValidateTestUserRegistrationRequest1;
        }
    }
