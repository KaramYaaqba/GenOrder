    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GeteBayOfficialTimeRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GeteBayOfficialTimeRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GeteBayOfficialTimeRequestType GeteBayOfficialTimeRequest1;
        
        public GeteBayOfficialTimeRequest()
        {
        }
        
        public GeteBayOfficialTimeRequest(CustomSecurityHeaderType RequesterCredentials,GeteBayOfficialTimeRequestType GeteBayOfficialTimeRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GeteBayOfficialTimeRequest1 = GeteBayOfficialTimeRequest1;
        }
    }
