    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FeedbackPeriodType
    {
        
        private int periodInDaysField;
        
        private bool periodInDaysFieldSpecified;
        
        private int countField;
        
        private bool countFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PeriodInDays
        {
            get
            {
                return this.periodInDaysField;
            }
            set
            {
                this.periodInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodInDaysSpecified
        {
            get
            {
                return this.periodInDaysFieldSpecified;
            }
            set
            {
                this.periodInDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
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
