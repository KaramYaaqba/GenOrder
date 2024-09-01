    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserNotesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetUserNotesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetUserNotesRequestType SetUserNotesRequest1;
        
        public SetUserNotesRequest()
        {
        }
        
        public SetUserNotesRequest(CustomSecurityHeaderType RequesterCredentials,SetUserNotesRequestType SetUserNotesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetUserNotesRequest1 = SetUserNotesRequest1;
        }
    }
