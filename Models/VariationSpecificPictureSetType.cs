    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VariationSpecificPictureSetType
    {
        
        private string variationSpecificValueField;
        
        private string[] pictureURLField;
        
        private string galleryURLField;
        
        private string[] externalPictureURLField;
        
        private ExtendedPictureDetailsType extendedPictureDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VariationSpecificValue
        {
            get
            {
                return this.variationSpecificValueField;
            }
            set
            {
                this.variationSpecificValueField = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string GalleryURL
        {
            get
            {
                return this.galleryURLField;
            }
            set
            {
                this.galleryURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalPictureURL", DataType="anyURI" )]
        public string[] ExternalPictureURL
        {
            get
            {
                return this.externalPictureURLField;
            }
            set
            {
                this.externalPictureURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ExtendedPictureDetailsType ExtendedPictureDetails
        {
            get
            {
                return this.extendedPictureDetailsField;
            }
            set
            {
                this.extendedPictureDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
