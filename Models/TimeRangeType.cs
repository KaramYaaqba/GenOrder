    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TimeRangeType
    {
        
        private System.DateTime timeFromField;
        
        private bool timeFromFieldSpecified;
        
        private System.DateTime timeToField;
        
        private bool timeToFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeFrom
        {
            get
            {
                return this.timeFromField;
            }
            set
            {
                this.timeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeFromSpecified
        {
            get
            {
                return this.timeFromFieldSpecified;
            }
            set
            {
                this.timeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeTo
        {
            get
            {
                return this.timeToField;
            }
            set
            {
                this.timeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeToSpecified
        {
            get
            {
                return this.timeToFieldSpecified;
            }
            set
            {
                this.timeToFieldSpecified = value;
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
