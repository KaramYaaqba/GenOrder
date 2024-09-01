    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseSellingManagerSaleRecordRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseSellingManagerSaleRecordRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseSellingManagerSaleRecordRequestType ReviseSellingManagerSaleRecordRequest1;
        
        public ReviseSellingManagerSaleRecordRequest()
        {
        }
        
        public ReviseSellingManagerSaleRecordRequest(CustomSecurityHeaderType RequesterCredentials,ReviseSellingManagerSaleRecordRequestType ReviseSellingManagerSaleRecordRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseSellingManagerSaleRecordRequest1 = ReviseSellingManagerSaleRecordRequest1;
        }
    }
