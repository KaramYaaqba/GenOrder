    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadSiteHostedPicturesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadSiteHostedPicturesRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public UploadSiteHostedPicturesRequestType UploadSiteHostedPicturesRequest1;
        
        public UploadSiteHostedPicturesRequest()
        {
        }
        
        public UploadSiteHostedPicturesRequest(CustomSecurityHeaderType RequesterCredentials,UploadSiteHostedPicturesRequestType UploadSiteHostedPicturesRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.UploadSiteHostedPicturesRequest1 = UploadSiteHostedPicturesRequest1;
        }
    }
