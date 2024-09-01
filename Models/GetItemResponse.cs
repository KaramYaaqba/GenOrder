    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetItemResponseType GetItemResponse1;
        
        public GetItemResponse()
        {
        }
        
        public GetItemResponse(CustomSecurityHeaderType RequesterCredentials,GetItemResponseType GetItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetItemResponse1 = GetItemResponse1;
        }
    }
