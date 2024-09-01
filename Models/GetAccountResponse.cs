    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccountResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccountResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetAccountResponseType GetAccountResponse1;
        
        public GetAccountResponse()
        {
        }
        
        public GetAccountResponse(CustomSecurityHeaderType RequesterCredentials,GetAccountResponseType GetAccountResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetAccountResponse1 = GetAccountResponse1;
        }
    }
