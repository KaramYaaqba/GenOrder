    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GeteBayOfficialTimeResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GeteBayOfficialTimeResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GeteBayOfficialTimeResponseType GeteBayOfficialTimeResponse1;
        
        public GeteBayOfficialTimeResponse()
        {
        }
        
        public GeteBayOfficialTimeResponse(CustomSecurityHeaderType RequesterCredentials,GeteBayOfficialTimeResponseType GeteBayOfficialTimeResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GeteBayOfficialTimeResponse1 = GeteBayOfficialTimeResponse1;
        }
    }
