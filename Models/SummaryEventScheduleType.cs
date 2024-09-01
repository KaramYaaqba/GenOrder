    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SummaryEventScheduleType
    {
        
        private NotificationEventTypeCodeType eventTypeField;
        
        private bool eventTypeFieldSpecified;
        
        private SummaryWindowPeriodCodeType summaryPeriodField;
        
        private bool summaryPeriodFieldSpecified;
        
        private SummaryFrequencyCodeType frequencyField;
        
        private bool frequencyFieldSpecified;
        
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
        public SummaryWindowPeriodCodeType SummaryPeriod
        {
            get
            {
                return this.summaryPeriodField;
            }
            set
            {
                this.summaryPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SummaryPeriodSpecified
        {
            get
            {
                return this.summaryPeriodFieldSpecified;
            }
            set
            {
                this.summaryPeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SummaryFrequencyCodeType Frequency
        {
            get
            {
                return this.frequencyField;
            }
            set
            {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrequencySpecified
        {
            get
            {
                return this.frequencyFieldSpecified;
            }
            set
            {
                this.frequencyFieldSpecified = value;
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
