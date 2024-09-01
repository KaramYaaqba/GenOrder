    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UploadSiteHostedPicturesResponseType : AbstractResponseType
    {
        
        private int pictureSystemVersionField;
        
        private bool pictureSystemVersionFieldSpecified;
        
        private SiteHostedPictureDetailsType siteHostedPictureDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PictureSystemVersion
        {
            get
            {
                return this.pictureSystemVersionField;
            }
            set
            {
                this.pictureSystemVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureSystemVersionSpecified
        {
            get
            {
                return this.pictureSystemVersionFieldSpecified;
            }
            set
            {
                this.pictureSystemVersionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SiteHostedPictureDetailsType SiteHostedPictureDetails
        {
            get
            {
                return this.siteHostedPictureDetailsField;
            }
            set
            {
                this.siteHostedPictureDetailsField = value;
            }
        }
    }
