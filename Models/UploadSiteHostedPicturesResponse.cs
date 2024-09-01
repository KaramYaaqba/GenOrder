    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadSiteHostedPicturesResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadSiteHostedPicturesResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public UploadSiteHostedPicturesResponseType UploadSiteHostedPicturesResponse1;
        
        public UploadSiteHostedPicturesResponse()
        {
        }
        
        public UploadSiteHostedPicturesResponse(CustomSecurityHeaderType RequesterCredentials,UploadSiteHostedPicturesResponseType UploadSiteHostedPicturesResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.UploadSiteHostedPicturesResponse1 = UploadSiteHostedPicturesResponse1;
        }
    }
