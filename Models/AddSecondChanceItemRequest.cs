    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSecondChanceItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSecondChanceItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSecondChanceItemRequestType AddSecondChanceItemRequest1;
        
        public AddSecondChanceItemRequest()
        {
        }
        
        public AddSecondChanceItemRequest(CustomSecurityHeaderType RequesterCredentials,AddSecondChanceItemRequestType AddSecondChanceItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSecondChanceItemRequest1 = AddSecondChanceItemRequest1;
        }
    }
