    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCategorySpecificsResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCategorySpecificsResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetCategorySpecificsResponseType GetCategorySpecificsResponse1;
        
        public GetCategorySpecificsResponse()
        {
        }
        
        public GetCategorySpecificsResponse(CustomSecurityHeaderType RequesterCredentials,GetCategorySpecificsResponseType GetCategorySpecificsResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetCategorySpecificsResponse1 = GetCategorySpecificsResponse1;
        }
    }
