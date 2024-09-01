    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NotificationStatisticsType
    {
        
        private int deliveredCountField;
        
        private bool deliveredCountFieldSpecified;
        
        private int queuedNewCountField;
        
        private bool queuedNewCountFieldSpecified;
        
        private int queuedPendingCountField;
        
        private bool queuedPendingCountFieldSpecified;
        
        private int expiredCountField;
        
        private bool expiredCountFieldSpecified;
        
        private int errorCountField;
        
        private bool errorCountFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DeliveredCount
        {
            get
            {
                return this.deliveredCountField;
            }
            set
            {
                this.deliveredCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveredCountSpecified
        {
            get
            {
                return this.deliveredCountFieldSpecified;
            }
            set
            {
                this.deliveredCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QueuedNewCount
        {
            get
            {
                return this.queuedNewCountField;
            }
            set
            {
                this.queuedNewCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueuedNewCountSpecified
        {
            get
            {
                return this.queuedNewCountFieldSpecified;
            }
            set
            {
                this.queuedNewCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QueuedPendingCount
        {
            get
            {
                return this.queuedPendingCountField;
            }
            set
            {
                this.queuedPendingCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueuedPendingCountSpecified
        {
            get
            {
                return this.queuedPendingCountFieldSpecified;
            }
            set
            {
                this.queuedPendingCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ExpiredCount
        {
            get
            {
                return this.expiredCountField;
            }
            set
            {
                this.expiredCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiredCountSpecified
        {
            get
            {
                return this.expiredCountFieldSpecified;
            }
            set
            {
                this.expiredCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ErrorCount
        {
            get
            {
                return this.errorCountField;
            }
            set
            {
                this.errorCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorCountSpecified
        {
            get
            {
                return this.errorCountFieldSpecified;
            }
            set
            {
                this.errorCountFieldSpecified = value;
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
