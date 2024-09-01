    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NotificationEnableType
    {
        
        private NotificationEventTypeCodeType eventTypeField;
        
        private bool eventTypeFieldSpecified;
        
        private EnableCodeType eventEnableField;
        
        private bool eventEnableFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationEventTypeCodeType EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventTypeSpecified
        {
            get
            {
                return this.eventTypeFieldSpecified;
            }
            set
            {
                this.eventTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public EnableCodeType EventEnable
        {
            get
            {
                return this.eventEnableField;
            }
            set
            {
                this.eventEnableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventEnableSpecified
        {
            get
            {
                return this.eventEnableFieldSpecified;
            }
            set
            {
                this.eventEnableFieldSpecified = value;
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
