    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendInvoiceResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendInvoiceResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SendInvoiceResponseType SendInvoiceResponse1;
        
        public SendInvoiceResponse()
        {
        }
        
        public SendInvoiceResponse(CustomSecurityHeaderType RequesterCredentials,SendInvoiceResponseType SendInvoiceResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SendInvoiceResponse1 = SendInvoiceResponse1;
        }
    }
