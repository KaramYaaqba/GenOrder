    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddTransactionConfirmationItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTransactionConfirmationItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddTransactionConfirmationItemResponseType AddTransactionConfirmationItemResponse1;
        
        public AddTransactionConfirmationItemResponse()
        {
        }
        
        public AddTransactionConfirmationItemResponse(CustomSecurityHeaderType RequesterCredentials,AddTransactionConfirmationItemResponseType AddTransactionConfirmationItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddTransactionConfirmationItemResponse1 = AddTransactionConfirmationItemResponse1;
        }
    }
