    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NotificationUserDataType
    {
        
        private SMSSubscriptionType sMSSubscriptionField;
        
        private SummaryEventScheduleType[] summaryScheduleField;
        
        private string externalUserDataField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SMSSubscriptionType SMSSubscription
        {
            get
            {
                return this.sMSSubscriptionField;
            }
            set
            {
                this.sMSSubscriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SummarySchedule" )]
        public SummaryEventScheduleType[] SummarySchedule
        {
            get
            {
                return this.summaryScheduleField;
            }
            set
            {
                this.summaryScheduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalUserData
        {
            get
            {
                return this.externalUserDataField;
            }
            set
            {
                this.externalUserDataField = value;
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
