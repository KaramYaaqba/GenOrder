    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MarkUpMarkDownEventType
    {
        
        private MarkUpMarkDownEventTypeCodeType typeField;
        
        private bool typeFieldSpecified;
        
        private System.DateTime timeField;
        
        private bool timeFieldSpecified;
        
        private string reasonField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MarkUpMarkDownEventTypeCodeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeSpecified
        {
            get
            {
                return this.timeFieldSpecified;
            }
            set
            {
                this.timeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
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
