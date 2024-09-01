    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReminderCustomizationType
    {
        
        private int durationInDaysField;
        
        private bool durationInDaysFieldSpecified;
        
        private bool includeField;
        
        private bool includeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DurationInDays
        {
            get
            {
                return this.durationInDaysField;
            }
            set
            {
                this.durationInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationInDaysSpecified
        {
            get
            {
                return this.durationInDaysFieldSpecified;
            }
            set
            {
                this.durationInDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeSpecified
        {
            get
            {
                return this.includeFieldSpecified;
            }
            set
            {
                this.includeFieldSpecified = value;
            }
        }
    }
