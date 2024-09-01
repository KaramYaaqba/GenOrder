    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSellingManagerProductRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSellingManagerProductRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSellingManagerProductRequestType AddSellingManagerProductRequest1;
        
        public AddSellingManagerProductRequest()
        {
        }
        
        public AddSellingManagerProductRequest(CustomSecurityHeaderType RequesterCredentials,AddSellingManagerProductRequestType AddSellingManagerProductRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSellingManagerProductRequest1 = AddSellingManagerProductRequest1;
        }
    }
