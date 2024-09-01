    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendInvoiceRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendInvoiceRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public SendInvoiceRequestType SendInvoiceRequest1;
        
        public SendInvoiceRequest()
        {
        }
        
        public SendInvoiceRequest(CustomSecurityHeaderType RequesterCredentials,SendInvoiceRequestType SendInvoiceRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.SendInvoiceRequest1 = SendInvoiceRequest1;
        }
    }
