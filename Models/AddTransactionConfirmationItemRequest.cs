    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddTransactionConfirmationItemRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTransactionConfirmationItemRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddTransactionConfirmationItemRequestType AddTransactionConfirmationItemRequest1;
        
        public AddTransactionConfirmationItemRequest()
        {
        }
        
        public AddTransactionConfirmationItemRequest(CustomSecurityHeaderType RequesterCredentials,AddTransactionConfirmationItemRequestType AddTransactionConfirmationItemRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddTransactionConfirmationItemRequest1 = AddTransactionConfirmationItemRequest1;
        }
    }
