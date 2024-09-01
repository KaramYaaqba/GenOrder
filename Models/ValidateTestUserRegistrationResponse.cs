    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateTestUserRegistrationResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateTestUserRegistrationResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ValidateTestUserRegistrationResponseType ValidateTestUserRegistrationResponse1;
        
        public ValidateTestUserRegistrationResponse()
        {
        }
        
        public ValidateTestUserRegistrationResponse(CustomSecurityHeaderType RequesterCredentials,ValidateTestUserRegistrationResponseType ValidateTestUserRegistrationResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ValidateTestUserRegistrationResponse1 = ValidateTestUserRegistrationResponse1;
        }
    }
