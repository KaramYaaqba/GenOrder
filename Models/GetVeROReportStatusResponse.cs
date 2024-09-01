    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVeROReportStatusResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVeROReportStatusResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetVeROReportStatusResponseType GetVeROReportStatusResponse1;
        
        public GetVeROReportStatusResponse()
        {
        }
        
        public GetVeROReportStatusResponse(CustomSecurityHeaderType RequesterCredentials,GetVeROReportStatusResponseType GetVeROReportStatusResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetVeROReportStatusResponse1 = GetVeROReportStatusResponse1;
        }
    }
