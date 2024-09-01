    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddToItemDescriptionResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddToItemDescriptionResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddToItemDescriptionResponseType AddToItemDescriptionResponse1;
        
        public AddToItemDescriptionResponse()
        {
        }
        
        public AddToItemDescriptionResponse(CustomSecurityHeaderType RequesterCredentials,AddToItemDescriptionResponseType AddToItemDescriptionResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddToItemDescriptionResponse1 = AddToItemDescriptionResponse1;
        }
    }
