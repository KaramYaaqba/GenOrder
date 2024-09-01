    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AnnouncementMessageType
    {
        
        private System.DateTime announcementStartTimeField;
        
        private bool announcementStartTimeFieldSpecified;
        
        private System.DateTime eventTimeField;
        
        private bool eventTimeFieldSpecified;
        
        private AnnouncementMessageCodeType messageTypeField;
        
        private bool messageTypeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime AnnouncementStartTime
        {
            get
            {
                return this.announcementStartTimeField;
            }
            set
            {
                this.announcementStartTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnnouncementStartTimeSpecified
        {
            get
            {
                return this.announcementStartTimeFieldSpecified;
            }
            set
            {
                this.announcementStartTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EventTime
        {
            get
            {
                return this.eventTimeField;
            }
            set
            {
                this.eventTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventTimeSpecified
        {
            get
            {
                return this.eventTimeFieldSpecified;
            }
            set
            {
                this.eventTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AnnouncementMessageCodeType MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageTypeSpecified
        {
            get
            {
                return this.messageTypeFieldSpecified;
            }
            set
            {
                this.messageTypeFieldSpecified = value;
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
