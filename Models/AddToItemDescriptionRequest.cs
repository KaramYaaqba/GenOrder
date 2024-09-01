    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToItemDescriptionRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToItemDescriptionRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddToItemDescriptionRequestType AddToItemDescriptionRequest1;
        
        public AddToItemDescriptionRequest()
        {
        }
        
        public AddToItemDescriptionRequest(CustomSecurityHeaderType RequesterCredentials,AddToItemDescriptionRequestType AddToItemDescriptionRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddToItemDescriptionRequest1 = AddToItemDescriptionRequest1;
        }
    }
