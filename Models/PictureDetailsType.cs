    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PictureDetailsType
    {
        
        private GalleryTypeCodeType galleryTypeField;
        
        private bool galleryTypeFieldSpecified;
        
        private PhotoDisplayCodeType photoDisplayField;
        
        private bool photoDisplayFieldSpecified;
        
        private string[] pictureURLField;
        
        private PictureSourceCodeType pictureSourceField;
        
        private bool pictureSourceFieldSpecified;
        
        private GalleryStatusCodeType galleryStatusField;
        
        private bool galleryStatusFieldSpecified;
        
        private string galleryErrorInfoField;
        
        private string[] externalPictureURLField;
        
        private ExtendedPictureDetailsType extendedPictureDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GalleryTypeCodeType GalleryType
        {
            get
            {
                return this.galleryTypeField;
            }
            set
            {
                this.galleryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GalleryTypeSpecified
        {
            get
            {
                return this.galleryTypeFieldSpecified;
            }
            set
            {
                this.galleryTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PhotoDisplayCodeType PhotoDisplay
        {
            get
            {
                return this.photoDisplayField;
            }
            set
            {
                this.photoDisplayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhotoDisplaySpecified
        {
            get
            {
                return this.photoDisplayFieldSpecified;
            }
            set
            {
                this.photoDisplayFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PictureSourceCodeType PictureSource
        {
            get
            {
                return this.pictureSourceField;
            }
            set
            {
                this.pictureSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureSourceSpecified
        {
            get
            {
                return this.pictureSourceFieldSpecified;
            }
            set
            {
                this.pictureSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GalleryStatusCodeType GalleryStatus
        {
            get
            {
                return this.galleryStatusField;
            }
            set
            {
                this.galleryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GalleryStatusSpecified
        {
            get
            {
                return this.galleryStatusFieldSpecified;
            }
            set
            {
                this.galleryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string GalleryErrorInfo
        {
            get
            {
                return this.galleryErrorInfoField;
            }
            set
            {
                this.galleryErrorInfoField = value;
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
