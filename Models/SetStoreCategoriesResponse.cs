    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetStoreCategoriesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetStoreCategoriesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetStoreCategoriesResponseType SetStoreCategoriesResponse1;
        
        public SetStoreCategoriesResponse()
        {
        }
        
        public SetStoreCategoriesResponse(CustomSecurityHeaderType RequesterCredentials,SetStoreCategoriesResponseType SetStoreCategoriesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetStoreCategoriesResponse1 = SetStoreCategoriesResponse1;
        }
    }
