    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VeROReportItemsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VeROReportItemsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public VeROReportItemsResponseType VeROReportItemsResponse1;
        
        public VeROReportItemsResponse()
        {
        }
        
        public VeROReportItemsResponse(CustomSecurityHeaderType RequesterCredentials,VeROReportItemsResponseType VeROReportItemsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.VeROReportItemsResponse1 = VeROReportItemsResponse1;
        }
    }
