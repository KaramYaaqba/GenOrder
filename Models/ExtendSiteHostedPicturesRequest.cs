    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExtendSiteHostedPicturesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExtendSiteHostedPicturesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ExtendSiteHostedPicturesRequestType ExtendSiteHostedPicturesRequest1;
        
        public ExtendSiteHostedPicturesRequest()
        {
        }
        
        public ExtendSiteHostedPicturesRequest(CustomSecurityHeaderType RequesterCredentials,ExtendSiteHostedPicturesRequestType ExtendSiteHostedPicturesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ExtendSiteHostedPicturesRequest1 = ExtendSiteHostedPicturesRequest1;
        }
    }
