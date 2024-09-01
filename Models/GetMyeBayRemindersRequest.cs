    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyeBayRemindersRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyeBayRemindersRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetMyeBayRemindersRequestType GetMyeBayRemindersRequest1;
        
        public GetMyeBayRemindersRequest()
        {
        }
        
        public GetMyeBayRemindersRequest(CustomSecurityHeaderType RequesterCredentials,GetMyeBayRemindersRequestType GetMyeBayRemindersRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetMyeBayRemindersRequest1 = GetMyeBayRemindersRequest1;
        }
    }
