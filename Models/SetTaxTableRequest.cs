    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetTaxTableRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetTaxTableRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetTaxTableRequestType SetTaxTableRequest1;
        
        public SetTaxTableRequest()
        {
        }
        
        public SetTaxTableRequest(CustomSecurityHeaderType RequesterCredentials,SetTaxTableRequestType SetTaxTableRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetTaxTableRequest1 = SetTaxTableRequest1;
        }
    }
