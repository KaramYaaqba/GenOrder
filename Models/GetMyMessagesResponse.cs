    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyMessagesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyMessagesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyMessagesResponseType GetMyMessagesResponse1;
        
        public GetMyMessagesResponse()
        {
        }
        
        public GetMyMessagesResponse(CustomSecurityHeaderType RequesterCredentials,GetMyMessagesResponseType GetMyMessagesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyMessagesResponse1 = GetMyMessagesResponse1;
        }
    }
