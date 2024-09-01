    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTaxTableRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTaxTableRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetTaxTableRequestType GetTaxTableRequest1;
        
        public GetTaxTableRequest()
        {
        }
        
        public GetTaxTableRequest(CustomSecurityHeaderType RequesterCredentials,GetTaxTableRequestType GetTaxTableRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetTaxTableRequest1 = GetTaxTableRequest1;
        }
    }
