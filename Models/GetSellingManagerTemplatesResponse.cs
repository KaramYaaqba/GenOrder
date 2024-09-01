    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSellingManagerTemplatesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSellingManagerTemplatesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public GetSellingManagerTemplatesResponseType GetSellingManagerTemplatesResponse1;
        
        public GetSellingManagerTemplatesResponse()
        {
        }
        
        public GetSellingManagerTemplatesResponse(CustomSecurityHeaderType RequesterCredentials,GetSellingManagerTemplatesResponseType GetSellingManagerTemplatesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.GetSellingManagerTemplatesResponse1 = GetSellingManagerTemplatesResponse1;
        }
    }
