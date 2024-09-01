    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeROReportItemsRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeROReportItemsRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VeROReportItemsRequestType VeROReportItemsRequest1;
        
        public VeROReportItemsRequest()
        {
        }
        
        public VeROReportItemsRequest(CustomSecurityHeaderType RequesterCredentials,VeROReportItemsRequestType VeROReportItemsRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VeROReportItemsRequest1 = VeROReportItemsRequest1;
        }
    }
