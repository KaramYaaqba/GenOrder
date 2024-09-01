    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PictureSetMemberType
    {
        
        private string memberURLField;
        
        private int pictureHeightField;
        
        private bool pictureHeightFieldSpecified;
        
        private int pictureWidthField;
        
        private bool pictureWidthFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string MemberURL
        {
            get
            {
                return this.memberURLField;
            }
            set
            {
                this.memberURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PictureHeight
        {
            get
            {
                return this.pictureHeightField;
            }
            set
            {
                this.pictureHeightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureHeightSpecified
        {
            get
            {
                return this.pictureHeightFieldSpecified;
            }
            set
            {
                this.pictureHeightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PictureWidth
        {
            get
            {
                return this.pictureWidthField;
            }
            set
            {
                this.pictureWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureWidthSpecified
        {
            get
            {
                return this.pictureWidthFieldSpecified;
            }
            set
            {
                this.pictureWidthFieldSpecified = value;
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
