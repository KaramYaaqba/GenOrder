    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStoreCustomPageResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStoreCustomPageResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStoreCustomPageResponseType SetStoreCustomPageResponse1;
        
        public SetStoreCustomPageResponse()
        {
        }
        
        public SetStoreCustomPageResponse(CustomSecurityHeaderType RequesterCredentials,SetStoreCustomPageResponseType SetStoreCustomPageResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStoreCustomPageResponse1 = SetStoreCustomPageResponse1;
        }
    }
