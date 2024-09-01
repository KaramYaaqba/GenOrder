    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserNotesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetUserNotesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetUserNotesResponseType SetUserNotesResponse1;
        
        public SetUserNotesResponse()
        {
        }
        
        public SetUserNotesResponse(CustomSecurityHeaderType RequesterCredentials,SetUserNotesResponseType SetUserNotesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetUserNotesResponse1 = SetUserNotesResponse1;
        }
    }
