    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateChallengeInputRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateChallengeInputRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ValidateChallengeInputRequestType ValidateChallengeInputRequest1;
        
        public ValidateChallengeInputRequest()
        {
        }
        
        public ValidateChallengeInputRequest(CustomSecurityHeaderType RequesterCredentials,ValidateChallengeInputRequestType ValidateChallengeInputRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ValidateChallengeInputRequest1 = ValidateChallengeInputRequest1;
        }
    }
