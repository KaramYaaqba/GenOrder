    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ExtendSiteHostedPicturesResponseType : AbstractResponseType
    {
        
        private string[] pictureURLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PictureURL", DataType="anyURI" )]
        public string[] PictureURL
        {
            get
            {
                return this.pictureURLField;
            }
            set
            {
                this.pictureURLField = value;
            }
        }
    }
