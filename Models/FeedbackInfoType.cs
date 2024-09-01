    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FeedbackInfoType
    {
        
        private string commentTextField;
        
        private CommentTypeCodeType commentTypeField;
        
        private bool commentTypeFieldSpecified;
        
        private string targetUserField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CommentText
        {
            get
            {
                return this.commentTextField;
            }
            set
            {
                this.commentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CommentTypeCodeType CommentType
        {
            get
            {
                return this.commentTypeField;
            }
            set
            {
                this.commentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentTypeSpecified
        {
            get
            {
                return this.commentTypeFieldSpecified;
            }
            set
            {
                this.commentTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TargetUser
        {
            get
            {
                return this.targetUserField;
            }
            set
            {
                this.targetUserField = value;
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
