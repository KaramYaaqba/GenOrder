    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetTaxTableResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SetTaxTableResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SetTaxTableResponseType SetTaxTableResponse1;
        
        public SetTaxTableResponse()
        {
        }
        
        public SetTaxTableResponse(CustomSecurityHeaderType RequesterCredentials,SetTaxTableResponseType SetTaxTableResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SetTaxTableResponse1 = SetTaxTableResponse1;
        }
    }
