    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStoreCategoriesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStoreCategoriesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStoreCategoriesRequestType SetStoreCategoriesRequest1;
        
        public SetStoreCategoriesRequest()
        {
        }
        
        public SetStoreCategoriesRequest(CustomSecurityHeaderType RequesterCredentials,SetStoreCategoriesRequestType SetStoreCategoriesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStoreCategoriesRequest1 = SetStoreCategoriesRequest1;
        }
    }
