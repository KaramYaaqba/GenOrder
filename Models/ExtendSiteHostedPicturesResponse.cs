    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExtendSiteHostedPicturesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExtendSiteHostedPicturesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ExtendSiteHostedPicturesResponseType ExtendSiteHostedPicturesResponse1;
        
        public ExtendSiteHostedPicturesResponse()
        {
        }
        
        public ExtendSiteHostedPicturesResponse(CustomSecurityHeaderType RequesterCredentials,ExtendSiteHostedPicturesResponseType ExtendSiteHostedPicturesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ExtendSiteHostedPicturesResponse1 = ExtendSiteHostedPicturesResponse1;
        }
    }
