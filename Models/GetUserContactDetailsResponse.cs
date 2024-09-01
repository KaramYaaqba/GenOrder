    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserContactDetailsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserContactDetailsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetUserContactDetailsResponseType GetUserContactDetailsResponse1;
        
        public GetUserContactDetailsResponse()
        {
        }
        
        public GetUserContactDetailsResponse(CustomSecurityHeaderType RequesterCredentials,GetUserContactDetailsResponseType GetUserContactDetailsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetUserContactDetailsResponse1 = GetUserContactDetailsResponse1;
        }
    }
