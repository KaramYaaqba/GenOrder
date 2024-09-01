    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UploadSiteHostedPicturesRequestType : AbstractRequestType
    {
        
        private string pictureNameField;
        
        private int pictureSystemVersionField;
        
        private bool pictureSystemVersionFieldSpecified;
        
        private PictureSetCodeType pictureSetField;
        
        private bool pictureSetFieldSpecified;
        
        private Base64BinaryType pictureDataField;
        
        private PictureUploadPolicyCodeType pictureUploadPolicyField;
        
        private bool pictureUploadPolicyFieldSpecified;
        
        private string[] externalPictureURLField;
        
        private PictureWatermarkCodeType[] pictureWatermarkField;
        
        private int extensionInDaysField;
        
        private bool extensionInDaysFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PictureName
        {
            get
            {
                return this.pictureNameField;
            }
            set
            {
                this.pictureNameField = value;
            }
        }
        
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
        public PictureSetCodeType PictureSet
        {
            get
            {
                return this.pictureSetField;
            }
            set
            {
                this.pictureSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureSetSpecified
        {
            get
            {
                return this.pictureSetFieldSpecified;
            }
            set
            {
                this.pictureSetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public Base64BinaryType PictureData
        {
            get
            {
                return this.pictureDataField;
            }
            set
            {
                this.pictureDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PictureUploadPolicyCodeType PictureUploadPolicy
        {
            get
            {
                return this.pictureUploadPolicyField;
            }
            set
            {
                this.pictureUploadPolicyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureUploadPolicySpecified
        {
            get
            {
                return this.pictureUploadPolicyFieldSpecified;
            }
            set
            {
                this.pictureUploadPolicyFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PictureWatermark" )]
        public PictureWatermarkCodeType[] PictureWatermark
        {
            get
            {
                return this.pictureWatermarkField;
            }
            set
            {
                this.pictureWatermarkField = value;
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
