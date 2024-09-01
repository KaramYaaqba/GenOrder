    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetNotificationsUsageResponseType : AbstractResponseType
    {
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private NotificationDetailsType[] notificationDetailsArrayField;
        
        private MarkUpMarkDownEventType[] markUpMarkDownHistoryField;
        
        private NotificationStatisticsType notificationStatisticsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeSpecified
        {
            get
            {
                return this.endTimeFieldSpecified;
            }
            set
            {
                this.endTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NotificationDetails", IsNullable=false)]
        public NotificationDetailsType[] NotificationDetailsArray
        {
            get
            {
                return this.notificationDetailsArrayField;
            }
            set
            {
                this.notificationDetailsArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("MarkUpMarkDownEvent", IsNullable=false)]
        public MarkUpMarkDownEventType[] MarkUpMarkDownHistory
        {
            get
            {
                return this.markUpMarkDownHistoryField;
            }
            set
            {
                this.markUpMarkDownHistoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationStatisticsType NotificationStatistics
        {
            get
            {
                return this.notificationStatisticsField;
            }
            set
            {
                this.notificationStatisticsField = value;
            }
        }
    }
