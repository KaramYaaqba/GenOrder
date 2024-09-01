    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SiteHostedPictureDetailsType
    {
        
        private string pictureNameField;
        
        private PictureSetCodeType pictureSetField;
        
        private bool pictureSetFieldSpecified;
        
        private PictureFormatCodeType pictureFormatField;
        
        private bool pictureFormatFieldSpecified;
        
        private string fullURLField;
        
        private string baseURLField;
        
        private PictureSetMemberType[] pictureSetMemberField;
        
        private string externalPictureURLField;
        
        private System.DateTime useByDateField;
        
        private bool useByDateFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public PictureFormatCodeType PictureFormat
        {
            get
            {
                return this.pictureFormatField;
            }
            set
            {
                this.pictureFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureFormatSpecified
        {
            get
            {
                return this.pictureFormatFieldSpecified;
            }
            set
            {
                this.pictureFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string FullURL
        {
            get
            {
                return this.fullURLField;
            }
            set
            {
                this.fullURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string BaseURL
        {
            get
            {
                return this.baseURLField;
            }
            set
            {
                this.baseURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PictureSetMember" )]
        public PictureSetMemberType[] PictureSetMember
        {
            get
            {
                return this.pictureSetMemberField;
            }
            set
            {
                this.pictureSetMemberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ExternalPictureURL
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
        public System.DateTime UseByDate
        {
            get
            {
                return this.useByDateField;
            }
            set
            {
                this.useByDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseByDateSpecified
        {
            get
            {
                return this.useByDateFieldSpecified;
            }
            set
            {
                this.useByDateFieldSpecified = value;
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
