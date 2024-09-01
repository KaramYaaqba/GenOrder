    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ExtendSiteHostedPicturesRequestType : AbstractRequestType
    {
        
        private string[] pictureURLField;
        
        private int extensionInDaysField;
        
        private bool extensionInDaysFieldSpecified;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ExtensionInDays
        {
            get
            {
                return this.extensionInDaysField;
            }
            set
            {
                this.extensionInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtensionInDaysSpecified
        {
            get
            {
                return this.extensionInDaysFieldSpecified;
            }
            set
            {
                this.extensionInDaysFieldSpecified = value;
            }
        }
    }
