    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStoreOptionsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStoreOptionsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetStoreOptionsResponseType GetStoreOptionsResponse1;
        
        public GetStoreOptionsResponse()
        {
        }
        
        public GetStoreOptionsResponse(CustomSecurityHeaderType RequesterCredentials,GetStoreOptionsResponseType GetStoreOptionsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetStoreOptionsResponse1 = GetStoreOptionsResponse1;
        }
    }
