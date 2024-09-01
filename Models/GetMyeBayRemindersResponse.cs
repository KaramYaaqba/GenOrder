    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyeBayRemindersResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyeBayRemindersResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyeBayRemindersResponseType GetMyeBayRemindersResponse1;
        
        public GetMyeBayRemindersResponse()
        {
        }
        
        public GetMyeBayRemindersResponse(CustomSecurityHeaderType RequesterCredentials,GetMyeBayRemindersResponseType GetMyeBayRemindersResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyeBayRemindersResponse1 = GetMyeBayRemindersResponse1;
        }
    }
